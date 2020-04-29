using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    public bool gameOver;
    int ballCounter;
    bool alreadyCanceled;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        gameOver = false;
        InvokeRepeating("Spawning", 1f, 2f);
        PlayerPrefs.SetInt("ballCounter", ballCounter);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == false)
        {
            CheckGameOver();
        }
        
        CheckLevel();
        if(PlayerPrefs.GetInt("score") != 0 && PlayerPrefs.GetInt("score") % 5 != 0)
        {
            alreadyCanceled = false;
        }
    }
    void Spawning()
    {
        BallCounter.instance.BallLevelUp();
        float random = Random.Range(0, 2);
        if (random == 0)
        {

            BallRespawning.instance.newBall();
        }
        if ( random == 1)
        {
            BallRespawning.instance.newBallUpset();
        }
    }
    void CheckGameOver()
    {
        if (PlayerPrefs.GetInt("ballCounter") == 35)
        {
            gameOver = true;
            CancelInvoke("Spawning");
            UnityAdManager.instance.ShowAd();
            if (PlayerPrefs.HasKey("highScore"))
            {
                if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("highScore"))
                {
                    PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
                }
            }
            else
            {
                PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
            }
            
        }
    }
    void CheckLevel()
    {
        if (!alreadyCanceled && PlayerPrefs.GetInt("score") % 5 == 0 && PlayerPrefs.GetInt("score") != 0)
        {
            CancelInvoke("Spawning");
            alreadyCanceled = true;
            if (PlayerPrefs.GetInt("score") == 5)
            {
                alreadyCanceled = true;
                InvokeRepeating("Spawning", 0.1f, 1.5f);
            }
            if (PlayerPrefs.GetInt("score") == 10)
            {
                CancelInvoke("Spawning");
                InvokeRepeating("Spawning", 0.1f, 1f);
            }
            if (PlayerPrefs.GetInt("score") == 15)
            {
                CancelInvoke("Spawning");
                InvokeRepeating("Spawning", 0.1f, 0.75f);
            }
            if (PlayerPrefs.GetInt("score") == 20)
            {
                CancelInvoke("Spawning");
                InvokeRepeating("Spawning", 0.1f, 0.5f);
            }
            if (PlayerPrefs.GetInt("score") == 25)
            {
                CancelInvoke("Spawning");
                InvokeRepeating("Spawning", 0.1f, 0.25f);
            }
            if (PlayerPrefs.GetInt("score") == 30)
            {
                CancelInvoke("Spawning");
                InvokeRepeating("Spawning", 0.1f, 0.1f);
            }
        }
    }
}
