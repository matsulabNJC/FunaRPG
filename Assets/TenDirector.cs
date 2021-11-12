using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneを使うために必要!!

public class TenDirector:MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("あああああ");
        if (collision.gameObject.tag == "Enter")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.tag == "Enter4")
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (collision.gameObject.tag == "Enter5")
        {
            SceneManager.LoadScene("Syokudou_2");
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
