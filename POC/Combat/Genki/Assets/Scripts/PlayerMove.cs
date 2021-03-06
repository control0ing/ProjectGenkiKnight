﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rigidbody;
    public Animator animator;
    Vector2 move;

    // Update is called once per frame
    void Update()
    {    
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        animator.SetFloat("Hor", move.x);
        animator.SetFloat("Ver", move.y);
    }

    void FixedUpdate()
    {
       rigidbody.MovePosition(rigidbody.position + move*speed * Time.fixedDeltaTime);
    }
}
