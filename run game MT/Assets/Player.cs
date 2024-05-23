using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpP = 300f; // ジャンプ力

    Rigidbody2D rbody; // リジッドボディを使うための宣言

    private Vector3 afterRectVelocity;

    // Start is called before the first frame update
    void Start()
    {
        // リジッドボディ2Dをコンポーネントから取得して変数に入れる
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // ジャンプをするためのコード（もしスペースキーが押されて、上方向に速度がない時に）
        if (Input.GetKeyDown(KeyCode.Space) && rbody.velocity.y == 0)
        {
            // リジッドボディに力を加える（上方向にジャンプ力をかける）
            rbody.AddForce(transform.up * jumpP);
        }

    }



}