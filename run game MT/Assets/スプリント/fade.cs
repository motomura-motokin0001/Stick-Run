using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class fade : MonoBehaviour
{
    public Image fadeImage; // フェードアウトに使うImage
    public float fadeSpeed = 1.0f; // フェードアウトの速度

    void Start()
    {
        StartCoroutine(FadeOutRoutine());
    }

    IEnumerator FadeOutRoutine()
    {
        Color currentColor = fadeImage.color;
        while (currentColor.a < 1.0f)
        {
            float alphaChange = Time.deltaTime * fadeSpeed;
            currentColor.a += alphaChange;
            fadeImage.color = currentColor;
            yield return null;
        }
        SceneManager.LoadScene("GameScene"); // ゲームシーンに移行
    }
}
