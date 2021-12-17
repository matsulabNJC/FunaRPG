using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * キャラの座標を変更するController
 */
public class MoveController : MonoBehaviour
{
    [SerializeField]
   public static float SPEED = 10.0f;
    private Rigidbody2D rigidBody;
    private Vector2 inputAxis;

    void Start()
    {
        // オブジェクトに設定しているRigidbody2Dの参照を取得する
        this.rigidBody = GetComponent<Rigidbody2D>();
        SPEED = MoveController.getPlayerSpeed();
    }

    void Update()
    {
        // x,ｙの入力値を得る
        // それぞれ+や-の値と入力の関連付けはInput Managerで設定されている
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // 速度を代入する
        rigidBody.velocity = inputAxis.normalized * SPEED;
    }

    public static float getPlayerSpeed()
    {
        return SPEED;
    }

    public void Speedchange()
    {
        SPEED=SPEED*10;
    }
}