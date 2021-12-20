using UnityEngine;
using System.Collections;
using UnityEngine.UI;//UI オブジェクトを扱う時は必須

public class QuizMgrInf : MonoBehaviour {
	
	//アタッチしたオブジェクトが呼ばれた時に実行される。
	void Start () {
		QuestionLabelSet ();
		AnswerLabelSet ();
	}
	
	private void QuestionLabelSet(){
		//特定の名前のオブジェクトを検索してアクセス
		Text qLabel = GameObject.Find("Quiz/QLabel").GetComponentInChildren<Text> ();
		//データをセットすることで、既存情報を上書きできる
		qLabel.text = "何が知りたいですか？";
	}

	private void  AnswerLabelSet(){
		//回答文面の作成
		string[] array = new string[]{ "短大について", "編入について" ,"主な行事について"};
		//ボタンが4つあるのでそれぞれ代入
		for (int i=1; i<=3 ; i++){
			Text ansLabel = GameObject.Find("Quiz/AnsButton" + i).GetComponentInChildren<Text> ();
			ansLabel.text = array[i-1];
		}
	}

}


