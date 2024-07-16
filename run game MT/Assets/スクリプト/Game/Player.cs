using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animator animator;
    public float jumpP = 300f; // ジャンプ力
    public float speed = 5f; // キャラクターの移動速度
    private Rigidbody2D rbody; // リジッドボディを使うための宣言

    // Start is called before the first frame update
    void Start()
    {
        // リジッドボディ2Dをコンポーネントから取得して変数に入れる
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.IsStart())
        {
            if (Input.GetKeyDown(KeyCode.Space) && rbody.velocity.y == 0)
            {
                // リジッドボディに力を加える（上方向にジャンプ力をかける）
                rbody.AddForce(transform.up * jumpP);
            }    
            // 入力の取得
            float moveHorizontal = Input.GetAxis("Horizontal");

            // 移動ベクトルの計算
            Vector3 movement = transform.right * moveHorizontal;

            // 移動の適用
            transform.position += movement * speed * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("RunD", true);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                animator.SetBool("RunD", false);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("RunA", true);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animator.SetBool("RunA", false);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 特定のプレハブに当たった場合にリザルトシーンに移行
        if (collision.gameObject.CompareTag("Target"))
        {
            // スコアを記録し、シーンを切り替える
            PlayerPrefs.SetInt("FinalScore", ScoreManager.instance.GetScore());
            SceneManager.LoadScene("Result");
        }
    }
}
