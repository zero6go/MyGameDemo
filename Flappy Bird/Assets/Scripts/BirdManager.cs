using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    public GameObject gameover;
    private bool flag=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag&&Input.GetMouseButtonDown(0)){
            this.GetComponent<Rigidbody2D>().velocity=new Vector3(0,5,0);
        }
        if(!flag){
            this.transform.Translate(new Vector3(-1*Time.deltaTime,0,0));
            this.GetComponent<Rigidbody2D>().angularVelocity=1000;
        }
        if(this.transform.position.y<=-6){
            if(GameObject.Find("GameManager").GetComponent<GameManager>().end!=true){
                GameObject.Find("GameManager").GetComponent<GameManager>().end=true;
                Instantiate(gameover);
            }
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="pipe"){
            GameObject.Find("GameManager").GetComponent<GameManager>().end=true;
            Instantiate(gameover);
            this.GetComponent<Animator>().enabled=false;
            flag=false;
        }
    }
}
