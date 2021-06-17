using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public GameObject Coin;
    public Transform GenerationPoint;

    public float DistanceBetween;

    float PlatformWidth;

    public float DistanceMin;
    public float DistanceMax;


    int SpikesSelector;

    void Start()
    {


    }


    void Update()
    {

        if (transform.position.x < GenerationPoint.position.x)
        {

            //нижние спайкс
            DistanceBetween = Random.Range(DistanceMin, DistanceMax);
            transform.position = new Vector3(transform.position.x + DistanceBetween, transform.position.y, transform.position.z);

            

            Instantiate(Coin, transform.position, transform.rotation);




        }

    }
}
