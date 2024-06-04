using UnityEngine;

public class Garbage_canController : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float minSpeed = 2.0f;
    public float maxSpeed = 5.0f;

    private float interval = 3.0f;
    private float timer = 0f;

    void Update()
    {
        // タイマーを更新
        timer += Time.deltaTime;

        // インターバルごとに障害物を生成
        if (timer >= interval)
        {
            SpawnObstacle();
            timer = 0f; // タイマーをリセット
        }
    }

    void SpawnObstacle()
    {
        float speed = Random.Range(minSpeed, maxSpeed);
        GameObject obstacle = Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = obstacle.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector2(-speed, 0f); // 障害物を右から左に動かす
        }
        Destroy(obstacle, 1f); // 一定時間後に障害物を破棄する（任意の時間を設定）
    }
}
