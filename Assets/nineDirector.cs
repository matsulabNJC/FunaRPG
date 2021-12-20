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
        if(collision.gameObject.tag=="Ticket")
        {
            SceneManager.LoadScene("Quiz_ticket");//券売機クイズ
        }
        if(collision.gameObject.tag=="Enter8")
        {
            SceneManager.LoadScene("KatoriLab");//香取研
        }
        if(collision.gameObject.tag=="Quiz")
        {
            SceneManager.LoadScene("KatoriLabQuiz");//香取研クイズ
        }
        if(collision.gameObject.tag=="QuizLab")
        {
            SceneManager.LoadScene("LaboratoryQuiz");
        }
        if(collision.gameObject.tag=="Map2Scene")
        {
            SceneManager.LoadScene("Map2Scene2");
        }
        if(collision.gameObject.tag=="Map2Scnen2_1")
        {
            SceneManager.LoadScene("Map2Scene3");
        }
        if(collision.gameObject.tag=="Map2Scnen2_2")
        {
            SceneManager.LoadScene("Map2Scene");
        }
        if(collision.gameObject.tag=="Map2Scnen3_1")
        {
            SceneManager.LoadScene("Map2Scene4");
        }
        if(collision.gameObject.tag=="Inf")
        {
            SceneManager.LoadScene("Information");
        }
        if(collision.gameObject.tag=="LastQ")
        {
            SceneManager.LoadScene("LastQuizStart");
        }
        if(collision.gameObject.tag=="InfQuiz")
        {
            SceneManager.LoadScene("KomadaInf");
        }
        if(collision.gameObject.tag=="Mob_1")
        {
            SceneManager.LoadScene("Mob_1");
        }
    }
    
}
