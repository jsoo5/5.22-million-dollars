using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOff : MonoBehaviour
{
    public GameObject box;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            box.SetActive(false);
            Debug.Log("Box Off");
        }
    }
}
