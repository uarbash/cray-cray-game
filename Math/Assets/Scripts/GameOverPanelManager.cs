using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanelManager : MonoBehaviour
{
    public GameObject curentScore;
    public GameObject gameOverPanel;
    public Text currentText;
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver)
        {
            currentText.text = "Your Score: "+ PlayerPrefs.GetInt("score").ToString();
            highScore.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
            gameOverPanel.SetActive(true);
            curentScore.SetActive(false);
        }
    }
}
