using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other)
   {
        Debug.Log("Player has collided with the object.");
   }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player has caught a donut.");
    }
}