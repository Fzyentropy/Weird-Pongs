using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{

    private GameObject ball;
    private GameObject ballLocation;
    private void Start()
    {
        ball = GameObject.Find("Ball");
        ballLocation = GameObject.Find("Ball Location");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ball"))
        {
            ball.transform.position = ballLocation.transform.position;
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            GameManager.score = 0;
        }
        
    }
}
