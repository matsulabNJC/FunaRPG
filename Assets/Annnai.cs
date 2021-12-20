using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Annnai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(DataAnnnai.Instance.referer=="KatoriLabQuizMaru"){
            Text AnnnaiLabel = GameObject.Find ("AnnnaiUI/Panel/AnnnaiLabel").GetComponent<Text> ();
			AnnnaiLabel.text = "昼休み:食堂でご飯を食べよう。";
        }
        if(DataAnnnai.Instance.referer=="Ticket"){
            Text AnnnaiLabel = GameObject.Find ("AnnnaiUI/Panel/AnnnaiLabel").GetComponent<Text> ();
			AnnnaiLabel.text = "3・4限目：6号館で実験を受けよう。";
        }
        if(DataAnnnai.Instance.referer=="SeikaiScene"){
            Text AnnnaiLabel = GameObject.Find ("AnnnaiUI/Panel/AnnnaiLabel").GetComponent<Text> ();
			AnnnaiLabel.text = "中央門で短大生レベルチェックを受けよう。";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
