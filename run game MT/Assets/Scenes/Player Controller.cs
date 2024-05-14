using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; //横移動速度
    public float jumpP = 300f; //ジャンプ力

    Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rbody.velocity.y == 0)
        {
            rbody.AddForce(transform.up * jumpP);
        }
    }    
    private void FixedUpdate()
    {
        //リジッドボディに一定の速度を入れる（横移動の速度, リジッドボディのyの速度）
        rbody.velocity = new Vector2(speed, rbody.velocity.y);
    }
}