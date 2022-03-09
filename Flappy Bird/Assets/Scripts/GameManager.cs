using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreUI;
    public float time=2f;
    public GameObject[] pipes;
    private float cnt=2f;
    private int Score=0;
    public bool end=false;
    public bool start=false;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(360,640,true);
        Screen.fullScreen=false;
        Application.targetFrameRate=60;
    }

    // Update is called once per frame
    void Update()
    {
        if(start){
            cnt+=Time.deltaTime;
            if(cnt>=time){
                cnt=0;
                Instantiate(pipes[Random.Range(0,pipes.Length)],new Vector3(2.4f,1.1f,-3f),Quaternion.identity);
            }
        }
        if(!start&&Input.GetMouseButtonDown(0)){
            start=true;
            ScoreUI.GetComponent<Text>().enabled=true;
            Destroy(GameObject.Find("tap"));
            Destroy(GameObject.Find("ready"));
        }
        if(end&&Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void addScore(){
        if(!end){
            Score++;
            ScoreUI.text=""+Score;
        }
    }
}
