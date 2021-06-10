using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject[] SpikesTop;

    public Transform GenerationPoint;

    public float DistanceBetween;

    float PlatformWidth;

    public float DistanceMin;
    public float DistanceMax;


    int SpikesSelector;

    void Start()
    {
        PlatformWidth = SpikesTop[0].GetComponent<PolygonCollider2D>().offset.x;

    }


    void Update()
    {

        if (transform.position.x < GenerationPoint.position.x)
        {

            //нижние спайкс
            DistanceBetween = Random.Range(DistanceMin, DistanceMax);
            transform.position = new Vector3(transform.position.x + PlatformWidth + DistanceBetween, transform.position.y, transform.position.z);

            SpikesSelector = Random.Range(0, SpikesTop.Length);

            Instantiate(SpikesTop[SpikesSelector], transform.position, transform.rotation);




        }

    }
}
