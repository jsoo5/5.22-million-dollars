using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreResultBox : MonoBehaviour
{
    List<Art> r1, r2, r3;
    GameObject am;
    GameObject b_tmp;

    public Sprite fail;
    public Sprite success;

    public int room_num;


    private void Start()
    {
        am = GameObject.Find("Art Manager");
        r1 = am.GetComponent<ArtManager>().stealRoom1;
        r2 = am.GetComponent<ArtManager>().stealRoom2;
        r3 = am.GetComponent<ArtManager>().stealRoom3;

        b_tmp = gameObject.transform.GetChild(0).gameObject;
        //Text s_price = s_picture.transform.GetChild(0).GetComponent<Text>();

        if (room_num == 1)
            ResultBox_1();
        else if (room_num == 2)
            ResultBox_2();
        else if (room_num == 3)
            ResultBox_3();
    }

    void ResultBox_1()
    {
        if (r1.Count > 0)
        {
            GameObject b;
            for (int i = 0; i < r1.Count; i++)
            {
                b = Instantiate(b_tmp, transform);

                if (r1[i].isReal == true)
                {
                    b.transform.GetComponent<Image>().sprite = success;
                    b.transform.GetChild(0).GetComponent<Text>().text = "success";
                }
                else
                {
                    b.transform.GetComponent<Image>().sprite = fail;
                    b.transform.GetChild(0).GetComponent<Text>().text = "fail";
                }
            }
            Destroy(b_tmp);
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
    void ResultBox_2()
    {
        if (r2.Count > 0)
        {
            GameObject b;
            for (int i = 0; i < r2.Count; i++)
            {
                b = Instantiate(b_tmp, transform);

                if (r2[i].isReal == true)
                {
                    b.transform.GetComponent<Image>().sprite = success;
                    b.transform.GetChild(0).GetComponent<Text>().text = "success";
                }
                else
                {
                    b.transform.GetComponent<Image>().sprite = fail;
                    b.transform.GetChild(0).GetComponent<Text>().text = "fail";
                }
            }
            Destroy(b_tmp);
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
    void ResultBox_3()
    {
        if (r3.Count > 0)
        {
            GameObject b;
            for (int i = 0; i < r3.Count; i++)
            {
                b = Instantiate(b_tmp, transform);

                if (r3[i].isReal == true)
                {
                    b.transform.GetComponent<Image>().sprite = success;
                    b.transform.GetChild(0).GetComponent<Text>().text = "success";
                }
                else
                {
                    b.transform.GetComponent<Image>().sprite = fail;
                    b.transform.GetChild(0).GetComponent<Text>().text = "fail";
                }
            }
            Destroy(b_tmp);
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
}
