using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript1 : MonoBehaviour
{
  // private AudioSource startmusic;
      // private float step_time;
      bool time;
  void Start()
  {
    time = true;
      // startmusic = GetComponent<AudioSource>();
  }

    // public void OnClick()
    // {
    //     startmusic.PlayOneShot(startmusic.clip);
              // SceneManager.LoadScene("SampleScene");
    // }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
          if (time) {
            GetComponent<AudioSource>().Play();
            time = false;
          }
          Debug.Log("Invokeセットしました。");
          Invoke("CallFunction",0.8f);
          }
      }
      void CallFunction(){
        SceneManager.LoadScene("SampleScene");
      }

}
