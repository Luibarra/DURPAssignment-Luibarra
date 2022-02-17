using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreKeeper : MonoBehaviour
{
    public Text highscoreText;
    public Text scoreText;
    int score, highscore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
        highscore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score++; 
        scoreText.text = "Score: " + score; 
    }

    public void UpdateHighscore()
    {
        if (score >= highscore)
        {   
            highscore = score;
            highscoreText.text = "Highscore: " + highscore;
            PlayerPrefs.SetInt("highscore", highscore);
        }
    }
}
