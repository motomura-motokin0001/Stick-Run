using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.U2D.IK;
using System.Runtime.InteropServices.WindowsRuntime;


public class CountdownManager : MonoBehaviour
{
public TextMeshProUGUI countdownText;
    public delegate void CountdownFinishedHandler();
    public event CountdownFinishedHandler OnCountdownFinished;

    void Start()
    {
        StartCoroutine(CountdownCoroutine());
    }

    private IEnumerator CountdownCoroutine()
    {
        for (int i = 3; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }

        countdownText.text = "GO!";
        yield return new WaitForSeconds(1); // "GO!"を表示するための1秒待機
        
        // TODO 非表示
        countdownText.text = "";
        GameManager.instance.GameStart();

        // カウントダウン終了を通知
        OnCountdownFinished?.Invoke();
    }

    
}