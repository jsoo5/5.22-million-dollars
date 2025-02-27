using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZoom : MonoBehaviour
{
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0)
        {
            Camera.main.fieldOfView = 20.0f;
        }
        else if (scroll < 0)
        {
            Camera.main.fieldOfView = 60.0f;
        }
    }
}
