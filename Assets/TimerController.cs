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

    // Start is called before the first frame update
    void Start()
    {
        Square = GameObject.Find("Square");
        script = Square.GetComponent<CardController>();
        total = totalTime;
        step_time = 0.0f;
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
                step_time += Time.deltaTime;
                GetComponent<AudioSource>().Play();
                if (step_time >= 3.0f){
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
