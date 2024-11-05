using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public AudioSource Obstacle;
   //public AudioSource Goal;
    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Obstacle"){
            Obstacle.Play();
        }
       
    }
}