　﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class MapKatoriLabDirector : MonoBehaviour
{
    bool time;
    void Start()
    {
      time = true;
    }
    void Update()
    {
      void OnCollisionEnter2D(Collision2D collision){
       if(collision.gameObject.tag=="Enter8"){
          if (time) {
            GetComponent<AudioSource>().Play();
            time = false;
          }
        Debug.Log("Invokeセットしました。");
        Invoke("CallFunction",1.0f);
        }
    }
  }   
}
