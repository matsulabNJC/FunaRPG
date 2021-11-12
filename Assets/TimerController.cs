using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public float totalTime;
    float total=0;
    int seconds;
    GameObject Square;
    CardController script;
    private float step_time;
    bool time;

    // Start is called before the first frame update
    void Start()
    {
        Square = GameObject.Find("Square");
        script = Square.GetComponent<CardController>();
        total = totalTime;
        step_time = 0.0f;
        time = true;
    }

    // Update is called once per frame
    void Update()
    {
        int n = script.n;

        if (n==1) {
            if (totalTime >= 0)
            {
                totalTime -= Time.deltaTime;
                seconds = (int)totalTime;
                timerText.text = seconds.ToString();
            }
            else {
                Debug.Log("Clear");
                  timerText.text = "Clear!";

                if (time) {
                  GetComponent<AudioSource>().Play();
                  time = false;
                }
                step_time += Time.deltaTime;
                if (step_time >= 1.0f){
                      SceneManager.LoadScene("Start");
              }
            }
        }
        else if(n==2){
            totalTime=total;
            seconds = (int)totalTime;
            timerText.text = seconds.ToString();
        }
    }
}
