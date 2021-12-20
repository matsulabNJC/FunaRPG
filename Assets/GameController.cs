using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static GameController _instance=null;

    static GameController instance{
        get{return _instance ?? (_instance=GameObject.FindObjectOfType<GameController>());}
    }

    void Awake(){
        if(this!=instance){
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);

    }

    void OnDestroy(){
        if(this==instance)_instance=null;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
