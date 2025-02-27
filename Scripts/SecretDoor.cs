using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDoor : MonoBehaviour
{
    float rotSpeed = 100f;
    Transform origin;
    GameObject picture;

    AudioSource audio;

    private void Start()
    {
        origin = gameObject.transform;
        audio = GetComponent<AudioSource>();
        //picture = transform.GetChild(0).gameObject;
    }

    private void OnMouseDrag()
    {        
        origin.eulerAngles += new Vector3 (0, -70.0f * Time.deltaTime, 0);
        //picture.transform.eulerAngles += new Vector3(0, -70.0f * Time.deltaTime, 0);
        audio.Play();
    }

}
