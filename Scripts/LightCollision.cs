using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollision : MonoBehaviour
{
    /*GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }*/

    private void OnTriggerEnter(Collider other)
    {
       if (other.name == "Player")
        {
            Debug.Log("Game Over");
        } 
    }
}
