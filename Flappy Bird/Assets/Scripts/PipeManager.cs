using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public float speed=-1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(speed*Time.deltaTime,0,0));
        if(this.transform.position.x<-5){
            Destroy(this.gameObject);
        }
    }
}
