using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Data.Instance.referer=="KatoriLab"){
            transform.position=new Vector3(23.8f,0.2f,0);
        }
        Data.Instance.referer="MapScene";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
