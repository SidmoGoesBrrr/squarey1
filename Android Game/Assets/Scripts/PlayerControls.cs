﻿using UnityEngine;

public class PlayerControls : MonoBehaviour
{
     public Rigidbody2D rb;
     public Transform groundCheck;
     public float groundCheckRadius;
     public LayerMask whatIsGround;
     private bool onGround;

void Start() {
     rb = GetComponent<Rigidbody2D>();
     }

    void Update() {
         rb.velocity = new Vector2(7, rb.velocity.y);
         onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);        
         if (Input.GetMouseButtonDown(0) && onGround) {
                 rb.velocity = new Vector2(rb.velocity.x, 10);
                 }

    }
    }

