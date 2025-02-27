using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleManager_2 : MonoBehaviour
{
    public List<string> subtitles = new List<string>();
    Text sub_txt;
    
    public GameObject sub, help;
    //public int sub_night;
            
    private void Awake()
    {
        // subtitles[0]
        subtitles.Add("경비가 교대하는 틈을 타 무사히 미술관 안으로 들어왔다!");
        // subtitles[1]
        subtitles.Add("그런데 낮에 본 작품들이 아닌 것 같은데...");
        // subtitles[2]
        subtitles.Add("아뿔싸! 오늘부터 AI와 명작 콜라보 전시가\n진행된다는 걸 깜빡했다!");
        // subtitles[3]
        subtitles.Add("역시 부자가 되는 길은 쉽지가 않군.\n명화만 잘 골라서 훔쳐보자!");

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

        for (int i = 0; i <= 3; i++)
        {
            sub_txt.text = subtitles[i];

            yield return new WaitForSecondsRealtime(4.0f);

        }
        sub.active = false;
        Time.timeScale = 1;
        help.active = true;
    }

}
