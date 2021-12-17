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
        if (collision.gameObject.tag == "Map2Scene")
        {
            SceneManager.LoadScene("Map2Scene2");
        }
        if (collision.gameObject.tag == "Map2Scene2_1")
        {
            SceneManager.LoadScene("Map2Scene3");
        }
        if (collision.gameObject.tag == "Map2Scene2_2")
        {
            SceneManager.LoadScene("Map2Scene");
        }
        if (collision.gameObject.tag == "Map2Scene3_1")
        {
            SceneManager.LoadScene("Map2Scene4");
        }
        if (collision.gameObject.tag == "Inf")
        {
            SceneManager.LoadScene("Information");
        }
        if (collision.gameObject.tag == "Obasann")
        {
            SceneManager.LoadScene("Ticket_Hint_BBA");
        }
        if (collision.gameObject.tag == "Enter6")
        {
            SceneManager.LoadScene("Syokudou");
        }
        if (collision.gameObject.tag == "Ticket")
        {
            SceneManager.LoadScene("Quiz_ticket");
        }
        
    }
}