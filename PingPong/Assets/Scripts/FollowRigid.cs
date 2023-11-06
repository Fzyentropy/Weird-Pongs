using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRigid : MonoBehaviour
{
    public GameObject rigid;
    void Start()
    {
        rigid = GameObject.Find("Racket-Collider");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rigid.transform.position;
    }
}
