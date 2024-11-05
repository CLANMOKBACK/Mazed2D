using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement; 

public class GoalCollision : MonoBehaviour
{
    public string nextLevelName; 
    public AudioSource Goal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            SceneManager.LoadScene(nextLevelName); 
            
        }
        
        }
    public void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player"){
            Goal.Play();
        }
       
    }
    }




