using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2Scene4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.referer=="Information"){
            transform.position=new Vector3(-26,-2.3f,0);
        }
       Data.Instance.referer="Map2Scene4"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
