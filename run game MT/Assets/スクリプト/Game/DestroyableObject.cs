using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    private void OnDestroy()
    {
        // オブジェクトが破壊されたときにスコアを更新
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.AddScore(10);
        }
    }
}
