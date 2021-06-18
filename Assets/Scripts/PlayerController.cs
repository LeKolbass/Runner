using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Transform Trans;

    public float movespeed;
    public float jumpforce;
    public static int CoinScore;
    Rigidbody2D rb;
    Collider2D Mycollider;
    public GameObject wings;
    public GameObject PanelRestart;
    public bool isGrounded;
    public bool Alive;
    public static bool isImmortal;


    public LayerMask WhatIsGround;



    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        Mycollider = GetComponent<Collider2D>();
        PanelRestart.SetActive(false);
        Alive = true;
}


    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(Mycollider, WhatIsGround);
        
        rb.velocity = new Vector2(movespeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.W) && Alive == true)
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
        if (Input.GetKeyDown(KeyCode.I) && ScoreManager.CoinScore >=10 && isImmortal == false)
        {
            StartCoroutine(shield());
            ScoreManager.CoinScore -= 10;
        }
        if(isImmortal == true)
        {
            wings.SetActive(true);
        }
        else
        {
            wings.SetActive(false);
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
            ScoreManager.CoinScore -= ScoreManager.CoinScore;
            //ScoreManager.score -= ScoreManager.score;
            Alive = false;
            gameObject.SetActive(false);
            PanelRestart.SetActive(true);
            
            //SceneManager.LoadScene(0);
        }
        if (other.tag.Equals("Shield") && isImmortal == false)
        {
            StartCoroutine(shield());
            Destroy(other.gameObject);
        }
    }


}
