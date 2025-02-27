using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject sound1, sound2, sound3, sound4, sound5;
    AudioSource s_1, s_2, s_3, s_4, s_5;

    public GameObject box2;

    private void Start()
    {
        s_1 = sound1.GetComponent<AudioSource>();
        s_2 = sound2.GetComponent<AudioSource>();
        s_3 = sound3.GetComponent<AudioSource>();
        s_4 = sound4.GetComponent<AudioSource>();
        s_5 = sound5.GetComponent<AudioSource>();

        StartCoroutine("SoundEffect");
    }

    IEnumerator SoundEffect()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10.0f, 30.0f));
            s_1.Play();

            yield return new WaitForSeconds(Random.Range(20.0f, 40.0f));
            s_2.Play();

            yield return new WaitForSeconds(Random.Range(20.0f, 40.0f));
            s_3.Play();
        }
    }
}
