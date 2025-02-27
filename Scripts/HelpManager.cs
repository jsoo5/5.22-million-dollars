using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpManager : MonoBehaviour
{
    public GameObject helpBox;
    Animator help_anim;
    Text help_txt;
    public int help_num = 0;

    private void Start()
    {
        help_anim = helpBox.GetComponent<Animator>();
        help_txt = helpBox.transform.GetChild(1).GetComponent<Text>(); 

    }

    private void Update()
    {
        // BoxShow.cs
        if (help_num == 1)
        {
            help_txt.text = "작품을 보기 위해서 손전등이 필요합니다. 손전등을 찾아주세요.";
        }
        // ItemController.cs, ArtSelect.cs
        else if (help_num == 2)
        {
            help_txt.text = "마우스를 스크롤하여 화면을 확대할 수 있습니다.";
        }
        // ArtSelect.cs
        else if (help_num == 3)
        {
            help_txt.text = "진짜 명작과 AI가 그린 가짜 작품이 섞여 있습니다. 진품을 선택해주세요.";
        }
        // ArtSelect.cs
        else if (help_num == 4)
        {
            help_txt.text = "최대 5개까지만 선택할 수 있습니다.";
        }
        else if (help_num == 5)
        {
            help_txt.text = "비밀번호를 입력해주세요.";
        }
        else if (help_num == 6)
        {
            help_txt.text = "잘못된 비밀번호입니다. 다시 입력해주세요.";
        }
        else if (help_num == 7)
        {
            help_txt.text = "<모나리자>를 훔쳐 미술관을 탈출하세요!";
        }
        else if(help_num == 8)
        {
            help_txt.text = "작품을 클릭하면 작품에 대한 정보를 볼 수 있습니다.";
        }
        // ArtSelect.cs
        else if (help_num == 9)
        {
            help_txt.text = "비밀의 문을 찾아 미술관을 탈출하세요.";
        }
        // QuizPlay.cs
        else if (help_num == 10)
        {
            help_txt.text = "학습한 작품에 대한 퀴즈를 풀어보세요.";
        }
        else
        {
            help_txt.text = "표시할 도움말이 없습니다.";
        }
    }

    public void HelpOn()
    {
        help_anim.SetTrigger("On");
        help_anim.SetTrigger("Off");
    }
}
