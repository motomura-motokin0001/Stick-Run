using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string NextScene;
    public float delay = 3f;  // 遅延時間を設定

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (!string.IsNullOrEmpty(NextScene))
        {
            StartCoroutine(LoadSceneAfterDelay());
        }
        else
        {
            Debug.LogError("シーン名が指定されていません。");
        }
    }

    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NextScene);
    }
}
