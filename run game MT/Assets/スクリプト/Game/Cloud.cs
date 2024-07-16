using Unity.VisualScripting;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float Speed = 2.0f;

    public float DestroyTime = 10.0f;

    private bool waitStart = true;

    void Update()
    {
        if(waitStart)
        {
            if(GameManager.instance.IsStart())
            {
                DelayDestroy(DestroyTime);
                float speed = Speed;
                SetVelocity(-speed);
                waitStart = false;
            }
        }
    }

    // 一定時間後に障害物を破棄する（任意の時間を設定）
    private void DelayDestroy(float DestroyTime)
    {
        Destroy(gameObject, DestroyTime); 
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
