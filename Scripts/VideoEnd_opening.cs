using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEnd_opening : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("SceneChange");
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSecondsRealtime(105.0f);
        SceneManager.LoadScene("LoadingToHome");
    }
}
