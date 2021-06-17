using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Transform Trans;

    public float movespeed;
    public float jumpforce;

    Rigidbody2D rb;
    Collider2D Mycollider;

    public bool isGrounded;
    public static bool isImmortal;


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

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            }

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector2(0.5f, 0.2f);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = new Vector2(0.5f, 0.5f);
        }
    }
    private IEnumerator shield()
    {
        isImmortal = true;
        yield return new WaitForSeconds(7);
        isImmortal = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Respawn" && isImmortal == false)
        {
            SceneManager.LoadScene(0);
        }
        if (other.tag.Equals("Shield"))
        {
            StartCoroutine(shield());
            Destroy(other.gameObject);
        }
    }


}
