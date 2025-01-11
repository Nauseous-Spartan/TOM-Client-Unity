using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{
    public float speed = 2f; // Speed of the movement
    public float range = 5f; // Distance the object moves left and right

    private Vector3 startPosition;

    void Start()
    {
        // Store the starting position of the object
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using Mathf.PingPong
        float movement = Mathf.PingPong(Time.time * speed, range * 2) - range;
        transform.position = new Vector3(startPosition.x + movement, startPosition.y, startPosition.z);
    }
}
