using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEnd_ending : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("SceneChange");
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSecondsRealtime(33.0f);
        SceneManager.LoadScene("LoadingToHome");
    }
}
