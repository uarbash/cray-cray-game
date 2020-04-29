using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawning : MonoBehaviour
{
    public GameObject Ball;
    public GameObject BallUpset;
    Vector2 BallPos;
    Vector2 BallUpsetpos;
    public static BallRespawning instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per fram
    void Update()
    {
        
    }
    public void newBall()
    {
        BallPos = Ball.transform.position;
        Instantiate(Ball, BallPos, Quaternion.identity);
    }
    public void newBallUpset()
    {
        BallUpsetpos = BallUpset.transform.position;
        Instantiate(BallUpset, BallUpsetpos, Quaternion.identity);
    }
}
