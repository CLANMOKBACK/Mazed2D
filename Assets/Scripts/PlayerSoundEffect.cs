using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundEffects : MonoBehaviour
{
    public AudioSource Obstacle;  // Sound for hitting obstacles
   // public AudioSource Goal;      // Sound for reaching the goal

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            
              Obstacle.Play();
            
    }
}