using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleManager_1 : MonoBehaviour
{
    public List<string> subtitles = new List<string>();
    public GameObject sub;
    public GameObject skip;
    Text sub_txt;
    public int sub_noon;

        
    private void Awake()
    {
        // subtitles[0]
        subtitles.Add("명화전이라니! 미술관은 처음 와보는군.");
        // subtitles[1]
        subtitles.Add("이것들만 있으면..내 빚쟁이 생활을 청산할 수 있겠어.");
        // subtitles[2]
        subtitles.Add("교양 있는 부자가 되어야지.\n답사하러 온 김에 미술사 공부를 좀 해볼까?");
    }

    private void Start()
    {
        sub_txt = sub.GetComponent<Text>();
        
        StartCoroutine("SubtitleShow");

    }

    IEnumerator SubtitleShow()
    {
        sub.active = true;
        Time.timeScale = 0;

        for (int i = 0; i <= sub_noon; i++)
        {
            sub_txt.text = subtitles[i];

            yield return new WaitForSecondsRealtime(3.0f);

        }
        sub.active = false;
        Time.timeScale = 1;
        skip.active = true;
    }
}
