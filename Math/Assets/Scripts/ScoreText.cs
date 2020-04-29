using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
        // GetScre();
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
 /*   void GetScore()
    {
        score = Ball.instance.score;
        scoreText.text = score.ToString();
        }
  */  
}
