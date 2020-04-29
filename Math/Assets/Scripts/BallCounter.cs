using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{

    public GameObject ball;
    Vector2 lastPos;
    public static BallCounter instance;
    GameObject clone;
    
    // Start is called before the first frame updte
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
         lastPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BallLevelUp()
    {
        
        Vector2 currentPos = lastPos;
        currentPos.y += 0.3f;
        lastPos = currentPos;
        clone = Instantiate(ball, currentPos, Quaternion.identity);
        clone.tag = (PlayerPrefs.GetInt("ballCounter")+1).ToString();
    }
    public void BallLevelDown()
    {
        lastPos.y -= 0.3f;
    }
}
