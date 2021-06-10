using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform Trans;

    public float movespeed;
    public float jumpforce;

    Rigidbody2D rb;
    Collider2D Mycollider;

    public bool isGrounded;
    public bool CanStand;

    public LayerMask WhatIsGround;
    public LayerMask WhatIsFloor;


    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        Mycollider = GetComponent<Collider2D>();
    }


    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(Mycollider, WhatIsGround);
        CanStand = Physics2D.IsTouchingLayers(Mycollider, WhatIsFloor);
        rb.velocity = new Vector2(movespeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            }

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector2(0.5f, 0.3f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = new Vector2(0.5f, 0.5f);
        }
    }

}
