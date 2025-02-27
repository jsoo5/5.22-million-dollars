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
        subtitles.Add("��ȭ���̶��! �̼����� ó�� �ͺ��±�.");
        // subtitles[1]
        subtitles.Add("�̰͵鸸 ������..�� ������ ��Ȱ�� û���� �� �ְھ�.");
        // subtitles[2]
        subtitles.Add("���� �ִ� ���ڰ� �Ǿ����.\n����Ϸ� �� �迡 �̼��� ���θ� �� �غ���?");
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
