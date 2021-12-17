using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Quiz_Judge_ticket2 : MonoBehaviour {
	public static bool Bool;
    //選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
    /*public void JudgeAnswer(){
        //正解のデータをテキストでセットする
        string answerText = "オシロスコープ";
        //選択したボタンのテキストラベルを取得する
        Text selectedBtn = this.GetComponentInChildren<Text> ();
        Debug.Log(selectedBtn.text);
        if (selectedBtn.text == answerText) {
            //選択したデータをグローバル変数に保存
            ResultMgr.SetJudgeData ("正解");
            // GetComponent<AudioSource>().Play();　音声
            Application.LoadLevel ("ResultLab");
        } else {
            //選択したデータをグローバル変数に保存
            ResultMgr.SetJudgeData ("不正解");
            Application.LoadLevel ("ResultLab");
        }
    }*/
    public void JudgeAnswer1(){
		Bool=true;
        SceneManager.LoadScene("food_speed_up");
    }
    public void JudgeAnswer2(){
		Bool=false;
        SceneManager.LoadScene("Syokudou_2");
    }
}
