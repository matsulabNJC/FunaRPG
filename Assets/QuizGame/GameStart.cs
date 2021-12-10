using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	public static int qCount;

	public void  NextScene(){
	
		if (Application.loadedLevelName == "Title") {
			Application.LoadLevel ("Quiz");
		
		}
	}

	public void NextQuiz(){
		int Score = ResultMgr.GetScoreData();
		if (Application.loadedLevelName == "Result") {
			 
			if(Score == 0){
				qCount++;
				SceneManager.LoadScene("KatoriLabQuizBatsu");
			}else{
				qCount = 0;
				SceneManager.LoadScene("KatoriLabQuizMaru");
				//Application.LoadLevel ("Score");
			
			}
		}
	}

	
	public void  BackToTitle(){
		
		if (Application.loadedLevelName == "Score") {
			ResultMgr.SetScoreData(0);
			Application.LoadLevel ("Start"); 
		}
	}

}
