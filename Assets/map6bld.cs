using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map6bld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.referer=="Laboratory6"){
            transform.position=new Vector3(38,-1.9f,0);
        }
        else if(Data.Instance.referer=="SampleScene"){
            transform.position=new Vector3(-34.5f,11.9f,0);
        }

        Data.Instance.referer="map6bld";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
