using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementRight : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;
    public float phaseOffset = 0f;
    private Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float movement = Mathf.PingPong((Time.time + phaseOffset) * speed, distance);
        transform.position = startPos + Vector2.right * movement;  // Now uses Vector2.up
    }
}
