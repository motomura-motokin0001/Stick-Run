using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GarbageController : MonoBehaviour
{
    public float minSpeed = 2.0f;
    public float maxSpeed = 5.0f;

    private bool waitStart = true;

    void Update()
    {
        if(waitStart)
        {
            if(GameManager.instance.IsStart())
            {
                DelayDestroy(5.0f);
                float speed = Random.Range(minSpeed, maxSpeed);
                SetVelocity(-speed);
                waitStart = false;
            }
        }
    }

    // 一定時間後に障害物を破棄する（任意の時間を設定）
    private void DelayDestroy(float delayTime = 0.0f)
    {
        Destroy(gameObject, delayTime); 
    }

    // 障害物を動かす
    private void SetVelocity(float speed)
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector2(speed, 0f); 
        }
    }

}
