using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syokudou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.referer=="Syokudou2"){
            transform.position=new Vector3(-0.21f,-5.82f,0);
        }
        Data.Instance.referer="Syokudou";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
