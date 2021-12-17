using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
	AudioSource audioSource;
	// Start is called before the first frame update
	void Start()
	{
			// Sceneを遷移してもオブジェクトが消えないようにする
			DontDestroyOnLoad(this);
			SceneManager.activeSceneChanged += OnActiveSceneChanged;
	}

	// Update is called once per frame
	void Update()
	{
        /*if (SceneManager.GetActiveScene().name == “Result”)
        {
			Destroy(gameObject);
        }*/
	}

	void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
	{
        if (nextScene.name == "Result")
        {

			audioSource = this.GetComponent<AudioSource>();
			audioSource.Stop();
			//or
			//Destroy(gameObject);
		
		}
        else return;
	}
}
	

