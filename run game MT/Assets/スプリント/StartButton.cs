using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{

    public void OnStartButtonClicked(){
    {
        SceneManager.LoadScene("GAME");
    }
    
}
}
