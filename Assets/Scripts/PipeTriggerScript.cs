using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Add additional reactions, like affecting the other object
        // For example, if you want to check for a specific tag:
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered the trigger!");
        }
    }
}
