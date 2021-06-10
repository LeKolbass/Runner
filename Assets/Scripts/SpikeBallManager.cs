using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBallGenerator : MonoBehaviour
{
    public GameObject SpikeBall;
    public Transform GenerationPoint;


    public float DistanceBetween;

    float PlatformWidth;

    public float DistanceMin;
    public float DistanceMax;


    void Start()
    {
        PlatformWidth = SpikeBall.GetComponent<PolygonCollider2D>().offset.x;

    }


    void Update()
    {


        if (transform.position.x < GenerationPoint.position.x)
        {
            DistanceBetween = Random.Range(DistanceMin, DistanceMax);

            transform.position = new Vector3(transform.position.x + PlatformWidth + DistanceBetween, transform.position.y, transform.position.z);

            Instantiate(SpikeBall, transform.position, transform.rotation);

        }


    }
}
