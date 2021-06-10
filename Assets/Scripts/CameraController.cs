using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;

    Vector3 LastPosition;

    float DistanceToMove;
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        LastPosition = player.transform.position;
    }


    void Update()
    {
        DistanceToMove = player.transform.position.x - LastPosition.x;
        transform.position = new Vector3(transform.position.x + DistanceToMove, transform.position.y, transform.position.z);
        LastPosition = player.transform.position;
    }
}
