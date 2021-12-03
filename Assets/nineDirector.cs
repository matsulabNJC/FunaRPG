using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneを使うために必要!!

public class nineDirector : MonoBehaviour
{
    void Start(){
    
    }
    void Update()
    {
        
    }
        void OnCollisionEnter2D(Collision2D collision)
        {
        Debug.Log("あああああ");
        if (collision.gameObject.tag == "Enter")
        {
            SceneManager.LoadScene("SampleScene");//全体マップ
        }
        if (collision.gameObject.tag == "Enter2")
        {
            SceneManager.LoadScene("MapScene");//2号館
        }
        if (collision.gameObject.tag == "Enter3")
        {
            SceneManager.LoadScene("Map2Scene");//9号館
        }
        if (collision.gameObject.tag == "Enter4")
        {
            SceneManager.LoadScene("map6bld");//6号館
        
        }
        if(collision.gameObject.tag=="Enter5")
        {
            SceneManager.LoadScene("Syokudou");//食堂1階
        }
        if(collision.gameObject.tag=="Enter6")
        {
            SceneManager.LoadScene("Syokudou_2");//食堂2階
        }
        if(collision.gameObject.tag=="Enter7")
        {
            SceneManager.LoadScene("Laboratory6");//実験室
            
        }
    }
    
}
