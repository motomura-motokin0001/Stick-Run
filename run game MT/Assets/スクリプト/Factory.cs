using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float interval = 2.0f;
    private float timer = 0f;

    void Start()
    {
        timer = interval;
    }

    void Update()
    {
        if(!GameManager.instance.IsStart()) { return; }

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
        GameObject obstacle = Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }
}
