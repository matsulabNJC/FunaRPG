using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript1 : MonoBehaviour
{
  private AudioSource startmusic;
  void Start()
  {
      startmusic = GetComponent<AudioSource>();
  }
    // Start is called before the first frame update
    public void OnClick()
    {
        startmusic.PlayOneShot(startmusic.clip);
        SceneManager.LoadScene("SampleScene");
    }
}
