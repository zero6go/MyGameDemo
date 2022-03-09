using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public bool add=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player"&&add){
            add=false;
            GameObject.Find("GameManager").GetComponent<GameManager>().addScore();
        }
    }
}
