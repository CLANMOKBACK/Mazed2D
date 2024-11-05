using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ObstacleMovementCross : MonoBehaviour
{
    public float moveSpeed = 2f;       
    public float segmentLength = 2f;   
    private Vector2 startPos;          
    private int currentDirection = 0;  
    private float traveledDistance = 0f;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        
        Vector2 movement;
        switch (currentDirection)
        {
            case 0: 
                movement = Vector2.right;
                break;
            case 1: 
                movement = Vector2.up;
                break;
            case 2: 
                movement = Vector2.left;
                break;
            case 3: 
                movement = Vector2.down;
                break;
            default:
                movement = Vector2.zero;
                break;
        }

        // Move the obstacle
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        traveledDistance += moveSpeed * Time.deltaTime;

        
        if (traveledDistance >= segmentLength)
        {
            traveledDistance = 0f;      
            currentDirection = (currentDirection + 1) % 4; //Switch to the next direction
        }
    }
}
