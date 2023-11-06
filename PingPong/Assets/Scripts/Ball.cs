using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D ballRigidbody;
    public float MaxSpeed = 5f;
    
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ballRigidbody.velocity.magnitude > MaxSpeed)
        {
            ballRigidbody.velocity = ballRigidbody.velocity.normalized * MaxSpeed;
        }
    }
}
