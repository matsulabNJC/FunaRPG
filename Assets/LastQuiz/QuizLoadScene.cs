using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuizLoadScene : MonoBehaviour {

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
    public void JudgeLoadScene(){
        SceneManager.LoadScene("LastQuiz");
    }

    


}
