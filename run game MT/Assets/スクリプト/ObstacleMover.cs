using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 2.0f;
    private bool shouldMove = false;

    void Update()
    {
        if (shouldMove)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    public void StartMoving()
    {
        shouldMove = true;
    }
}
