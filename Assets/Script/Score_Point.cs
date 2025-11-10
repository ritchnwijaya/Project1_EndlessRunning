using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Point : MonoBehaviour
{
    public Text ScoreText;
    private float Score;
    public Text HighScoreText;
    private float highScore;
    public GameObject player;
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        HighScoreText.text = "High Score: " + ((int)highScore).ToString();
    }


    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Score = Score + (10 * Time.deltaTime);
            ScoreText.text = ((int)Score).ToString();
        }


        if (Score > highScore)
        {
            highScore = Score;
            PlayerPrefs.SetFloat("HighScore", highScore);
            HighScoreText.text = "High Score: " + ((int)highScore).ToString();
        }
        
    }
}
