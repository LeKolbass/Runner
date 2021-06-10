using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBallController : MonoBehaviour
{
    float diry;

    public float Movespeed;
    
    bool MovingUp = true;

    void Start()
    {
        
    }


    void Update()
    {
        if(transform.position.y > 2f)
        {
            MovingUp = false;
        }
        else if(transform.position.y < -0.5f)
        {
            MovingUp = true;
        }

        if(MovingUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + Movespeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - Movespeed * Time.deltaTime);
        }


    }
}
