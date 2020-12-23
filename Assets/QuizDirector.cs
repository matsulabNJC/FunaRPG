using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneを使うために必要!!

public class QuizDirector : MonoBehaviour
{
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("あああああ");
        if (collider.gameObject.tag == "Message")
        {
            SceneManager.LoadScene("Quiz");
        }
    }
}