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
        subtitles.Add("��� �����ϴ� ƴ�� Ÿ ������ �̼��� ������ ���Դ�!");
        // subtitles[1]
        subtitles.Add("�׷��� ���� �� ��ǰ���� �ƴ� �� ������...");
        // subtitles[2]
        subtitles.Add("�ƻԽ�! ���ú��� AI�� ���� �ݶ� ���ð�\n����ȴٴ� �� �����ߴ�!");
        // subtitles[3]
        subtitles.Add("���� ���ڰ� �Ǵ� ���� ������ �ʱ�.\n��ȭ�� �� ��� ���ĺ���!");

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
