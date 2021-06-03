using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed;
    public float jumpforce;
    
    Rigidbody2D rb;
    Collider2D Mycollider;
    
    public bool isGrounded;

    public LayerMask WhatIsGround;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Mycollider = GetComponent<Collider2D>();
    }

 
    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(Mycollider, WhatIsGround);
        rb.velocity = new Vector2(movespeed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            }
            
        }
    }
}
