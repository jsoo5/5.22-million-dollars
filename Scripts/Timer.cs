using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float currentTime;
    public static string currentStringTime;
    public Text time_txt;
    

    void Update()
    {
        currentTime += Time.deltaTime;
        UpdateTimer(currentTime);
    }

    void UpdateTimer(float time)
    {
        float hour = Mathf.FloorToInt((time / 60) / 60);
        float min = Mathf.FloorToInt(time / 60);
        float sec = Mathf.FloorToInt(time % 60);

        currentStringTime = string.Format("{0:00:}{1:00:}{2:00}", hour, min, sec);
        time_txt.text = currentStringTime.ToString();

    }
}
