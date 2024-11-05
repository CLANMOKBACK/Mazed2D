using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Vector2 startPosition;

    private void Start()
    {
        // Set the initial start position to reset to
        startPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Reset the player position on collision with an obstacle
            transform.position = startPosition;
        }
    }
}

