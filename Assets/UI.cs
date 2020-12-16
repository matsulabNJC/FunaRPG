using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 左クリックしたとき、オブジェクト表示
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(true);
        }


    }
}
