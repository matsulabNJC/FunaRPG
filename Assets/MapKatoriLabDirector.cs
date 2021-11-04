using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapKatoriLabDirector : MonoBehaviour
{
    private float step_time;
    bool time;
    void Start()
    {
        step_time = 0.0f;
      time = true;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
          if (time) {
            GetComponent<AudioSource>().Play();
            time = false;
          }
          step_time += Time.deltaTime;
          if (step_time >= 1.0f){
                SceneManager.LoadScene("KatoriLab");
        }
        }
    }
}
