using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-1*Time.deltaTime,0,0);
        if(this.transform.position.x<=-5.67){
            this.transform.Translate(11.34f,0,0);
        }
    }
}
