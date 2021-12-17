using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket_hanntei : MonoBehaviour {
    
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.tag == "player_tag")  // 壁にぶつかったら
        {
            this.tag = "Enter5";             // タグを変更する
        }
    }
}
