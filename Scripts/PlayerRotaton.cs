using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotaton : MonoBehaviour
{
    public float rotSpeed = 300f;
    float mx = 0;

    void Update()
    {
        //CursorFixOn();
        
        float mouse_X = Input.GetAxis("Mouse X");
        mx += mouse_X * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
    }

    void CursorFixOn()
    {
        //Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
