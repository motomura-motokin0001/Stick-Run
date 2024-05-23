using UnityEngine;

public class Garbage_canController : MonoBehaviour
{
    public GameObject Garbage_can_Prefab;
    public float moveSpeed = 0.5f;
    public float respawnXPosition = -3.5f;
    public float destroyXPosition = -9.5f;
    void Update()
    {
    transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (transform.position.x < destroyXPosition)
        {
        Instantiate(Garbage_can_Prefab,new Vector3(respawnXPosition,transform.position.y,transform.position.z),Quaternion.identity);                Destroy(gameObject);
        }
    }
}
