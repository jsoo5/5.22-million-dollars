using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    GameObject am;
    GameObject im;

    void Start()
    {
        am = GameObject.Find("Art Manager");
        im = GameObject.Find("Inventory Manager");

        Destroy(am);
        Destroy(im);

        Timer.currentTime = 0;
    }
}
