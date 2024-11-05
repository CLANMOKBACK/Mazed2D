using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementDown : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;
    public float phaseOffset = 0f;  // variable to control initial movement direction
    private Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float movement = Mathf.PingPong((Time.time + phaseOffset) * speed, distance);
        transform.position = startPos + Vector2.down * movement; 
    }
}