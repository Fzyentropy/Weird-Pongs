using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowControl : MonoBehaviour
{

    public GameObject control;
    public Rigidbody2D rb;
    public float speed = 1f;
    
    void Start()
    {
        if (control == null)
        {
            control = GameObject.Find("Control");
        }

        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if ( Vector2.Distance(gameObject.transform.position, control.transform.position) > 0.05f)
        // {
        //     Vector2 direction = (control.transform.position - gameObject.transform.position).normalized;
        //     Vector2 velocity = direction * speed;
        //     rb.velocity = velocity;
        // }
        //
        // if (Vector2.Distance(gameObject.transform.position, control.transform.position) <= 0.05f)
        // {
        //     gameObject.transform.position = control.transform.position;
        // }

        if (gameObject.transform.position != control.transform.position)
        {
            rb.MovePosition(control.transform.position);
        }
        
    }
}
