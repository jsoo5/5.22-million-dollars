using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolusion : MonoBehaviour
{
    void Awake()
    {
        Screen.SetResolution((Screen.height / 9) * 16, Screen.height, true);

        //Screen.SetResolution(Screen.width, (Screen.width * 16) / 9, true);
    }
}
