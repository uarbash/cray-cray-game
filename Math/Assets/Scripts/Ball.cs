using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public static Ball instance;
    void Awake()
    {
        if ( instance == null )
        {
            instance = this;
        }
    }
    void Start()
    {
        PlayerPrefs.SetInt("ballCounter", PlayerPrefs.GetInt("ballCounter") + 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (!GameManager.instance.gameOver)
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            PlayerPrefs.SetInt("ballCounter", PlayerPrefs.GetInt("ballCounter") - 1);
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag((PlayerPrefs.GetInt("ballCounter")+1).ToString()));
            BallCounter.instance.BallLevelDown();
        }
        
        
    }

}
