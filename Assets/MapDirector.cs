using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapDirector : MonoBehaviour
{

    
    // ゴールに到達
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("map");
        SceneManager.LoadScene("SampleScene");
    }
}