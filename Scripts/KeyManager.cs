using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class KeyManager : MonoBehaviour
{
    public static KeyManager Instance;
    public List<int> keyNumber = new List<int>();
    public GameObject pw;
    public GameObject keypad, key_lock;
    public bool isCorrect = false;
    public bool isIncorrect = false;

    public GameObject door;

    Animator pw_anim;
    Animator door_anim;

    HelpManager helpManager;
    GameObject help_box;
    Animator help_anim;


    private void Start()
    {
        Instance = this;
        pw_anim = key_lock.GetComponent<Animator>();
        door_anim = door.GetComponent<Animator>();
        //keyButton = keypad.transform.GetComponentInChildren<KeyButton>().keyButton;

        helpManager = GameObject.Find("Help Manager").GetComponent<HelpManager>();
        help_box = GameObject.Find("help box");
        help_anim = help_box.GetComponent<Animator>();
    }

    public void Add(int[] keyButton)    // 최대 4자리까지
    {
        //if (keyNumber.Count < 4)
        //{
        keyNumber.Add(keyButton[0]);
        //}
    }

    public void ShowNumber()    // 숫자 입력
    {
        for(int i = 0; i < keyNumber.Count; i++)
        {
            pw.transform.GetChild(i).GetComponent<Text>().text = keyNumber[i].ToString();
        }

        /*pw_1.text = keyNumber[0].ToString();
        pw_2.text = keyNumber[1].ToString();
        pw_3.text = keyNumber[2].ToString();
        pw_4.text = keyNumber[3].ToString();*/
    }

    void Update()
    {
        if (keyNumber.Count == 4)
        {
            if (keyNumber[0] == 3 && keyNumber[1] == 4
                    && keyNumber[2] == 5 && keyNumber[3] == 1)
            {
                pw_anim.SetTrigger("Correct");
                isCorrect = true;

                StartCoroutine(CheckDelay());
                helpManager.help_num = 7;
                help_anim.SetTrigger("On");
            }

            else
            {
                //print("잘못된 비밀번호입니다. 다시 입력해주세요.");
                helpManager.help_num = 6;
                help_anim.SetTrigger("On");
                help_anim.SetTrigger("Off");

                isIncorrect = true;
                pw_anim.SetTrigger("Wrong");

                pw.transform.GetChild(0).GetComponent<Text>().text = "";
                pw.transform.GetChild(1).GetComponent<Text>().text = "";
                pw.transform.GetChild(2).GetComponent<Text>().text = "";
                pw.transform.GetChild(3).GetComponent<Text>().text = "";
            }
        }

        if (isIncorrect)
        {
            keyNumber.Clear();
            isIncorrect = false;
        }
        
    }

    IEnumerator CheckDelay()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        keypad.SetActive(false);
        door_anim.SetTrigger("isCorrect");
        
    }
}
