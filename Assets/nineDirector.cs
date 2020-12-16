using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneを使うために必要!!

public class nineDirector : MonoBehaviour
{
    void Update()
    {
    }
        void OnCollisionEnter2D(Collision2D collision)
        {
        Debug.Log("あああああ");
            if (collision.gameObject.tag == "Enter")
            {
                SceneManager.LoadScene("MapScene");
            }
        if (collision.gameObject.tag == "Enter2")
        {
                SceneManager.LoadScene("Map2Scene");
        }

        }
    
}
