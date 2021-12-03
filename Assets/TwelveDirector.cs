using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneを使うために必要!!

public class TwelveDirector : MonoBehaviour
{
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("あああああ");
        if (collision.gameObject.tag == "Enter7")
        {
            SceneManager.LoadScene("LaboratoryQuiz");
        }
    }
}