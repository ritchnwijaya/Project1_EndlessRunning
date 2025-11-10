using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject pauseMenu;
    bool isPaused = false;
    bool hasDied = false;


    // Update is called once per frame
    void Update()
    {
        if (!hasDied && GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
            BackgroundMusic.bgmusic?.PauseMusic(); // restart when player dies
            hasDied = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

    }

    public void Restart()
    {
        BackgroundMusic.bgmusic?.RestartMusic();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
        if (isPaused)
        {
            BackgroundMusic.bgmusic?.PauseMusic();
        }
        else
        {
            BackgroundMusic.bgmusic?.ResumeMusic();
        }
    }
    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        BackgroundMusic.bgmusic?.ResumeMusic();
    }
}
