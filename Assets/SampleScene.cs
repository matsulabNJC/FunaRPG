using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.referer=="map6bld"){
            transform.position=new Vector3(0,17.9f,0);
        }
        else if(Data.Instance.referer=="MapScene"){
            transform.position=new Vector3(27.2f,10,0);
        }
        else if(Data.Instance.referer=="Map2Scene"){
            transform.position=new Vector3(-34,30,0);
        }
        else if(Data.Instance.referer=="Syokudou"){
            transform.position=new Vector3(-3,-3.6f,0);
        }
        Data.Instance.referer="SampleScene";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
