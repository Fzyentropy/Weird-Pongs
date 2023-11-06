using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bounce : MonoBehaviour
{

    public float bounceForce = 10f;
    public AudioSource audioBounce;

    private void Start()
    {
        audioBounce = GameObject.Find("Audio-Bounce").GetComponent<AudioSource>();
    }

    private void Update()
    {
        bounceForce = GameManager.score * 50f;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            GameManager.score++;
            audioBounce.Play();
            Vector2 randomForce = new Vector2(Random.Range(-bounceForce, bounceForce), bounceForce);
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(randomForce,ForceMode2D.Force);
        }
    }
    
}
