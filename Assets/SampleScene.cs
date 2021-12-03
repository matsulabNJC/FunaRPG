using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.referer=="map6bld"){
            transform.position=new Vector3(-8.5f,-6.1f,0);
        }
        else if(Data.Instance.referer=="MapScene"){
            transform.position=new Vector3(13.6f,-8.84f,0);
        }
        else if(Data.Instance.referer=="Map2Scene"){
            transform.position=new Vector3(-33.69f,10.57f,0);
        }
        
        Data.Instance.referer="SampleScene";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
