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
            help_txt.text = "��ǰ�� ���� ���ؼ� �������� �ʿ��մϴ�. �������� ã���ּ���.";
        }
        // ItemController.cs, ArtSelect.cs
        else if (help_num == 2)
        {
            help_txt.text = "���콺�� ��ũ���Ͽ� ȭ���� Ȯ���� �� �ֽ��ϴ�.";
        }
        // ArtSelect.cs
        else if (help_num == 3)
        {
            help_txt.text = "��¥ ���۰� AI�� �׸� ��¥ ��ǰ�� ���� �ֽ��ϴ�. ��ǰ�� �������ּ���.";
        }
        // ArtSelect.cs
        else if (help_num == 4)
        {
            help_txt.text = "�ִ� 5�������� ������ �� �ֽ��ϴ�.";
        }
        else if (help_num == 5)
        {
            help_txt.text = "��й�ȣ�� �Է����ּ���.";
        }
        else if (help_num == 6)
        {
            help_txt.text = "�߸��� ��й�ȣ�Դϴ�. �ٽ� �Է����ּ���.";
        }
        else if (help_num == 7)
        {
            help_txt.text = "<�𳪸���>�� ���� �̼����� Ż���ϼ���!";
        }
        else if(help_num == 8)
        {
            help_txt.text = "��ǰ�� Ŭ���ϸ� ��ǰ�� ���� ������ �� �� �ֽ��ϴ�.";
        }
        // ArtSelect.cs
        else if (help_num == 9)
        {
            help_txt.text = "����� ���� ã�� �̼����� Ż���ϼ���.";
        }
        // QuizPlay.cs
        else if (help_num == 10)
        {
            help_txt.text = "�н��� ��ǰ�� ���� ��� Ǯ�����.";
        }
        else
        {
            help_txt.text = "ǥ���� ������ �����ϴ�.";
        }
    }

    public void HelpOn()
    {
        help_anim.SetTrigger("On");
        help_anim.SetTrigger("Off");
    }
}
