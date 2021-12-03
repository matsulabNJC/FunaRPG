　﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapKatoriLabDirector : MonoBehaviour
{
    bool time;
    void Start()
    {
      time = true;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
          if (time) {
            GetComponent<AudioSource>().Play();
            time = false;
          }
        Debug.Log("Invokeセットしました。");
        Invoke("CallFunction",1.0f);
        }
    }
    void CallFunction(){
      SceneManager.LoadScene("KatoriLab");
    }
}
