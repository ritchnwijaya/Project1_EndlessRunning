using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuController : MonoBehaviour
{
    [SerializeField] string WelcomeScene = "StartScene";
    [SerializeField] Button exitBTN;

    public void OnStartClick()
    {
        BackgroundMusic.bgmusic?.RestartMusic();
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

    public void OnHomeClick()
    {
        BackgroundMusic.bgmusic?.PauseMusic(); // pause when going home
        Time.timeScale = 1f;
        SceneManager.LoadScene(WelcomeScene);

    }
    public void OnExitClick()
    {
        Application.Quit();
    }
}
