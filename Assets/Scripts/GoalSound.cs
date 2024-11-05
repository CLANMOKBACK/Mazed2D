using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSound : MonoBehaviour
{
    public AudioSource Goal;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Goal.Play();
    }
}
