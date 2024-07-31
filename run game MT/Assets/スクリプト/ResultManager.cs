using TMPro;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    private void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore");
        finalScoreText.text = finalScore + " POINT";
    }
}
