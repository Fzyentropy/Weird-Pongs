using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zero : MonoBehaviour
{

    public AudioSource bounce;

    private void Start()
    {
        bounce = GameObject.Find("Audio-BounceWall").GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            // GameManager.score = 0;
            bounce.Play();
        }
        
    }
}
