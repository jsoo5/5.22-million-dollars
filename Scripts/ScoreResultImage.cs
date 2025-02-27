using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResultImage : MonoBehaviour
{
    List<Art> r1, r2, r3;
    GameObject am;
    GameObject a_tmp;

    public int room_num;

    private void Start()
    {
        am = GameObject.Find("Art Manager");
        r1 = am.GetComponent<ArtManager>().stealRoom1;
        r2 = am.GetComponent<ArtManager>().stealRoom2;
        r3 = am.GetComponent<ArtManager>().stealRoom3;

        a_tmp = gameObject.transform.GetChild(0).gameObject;

        //Text s_price = s_picture.transform.GetChild(0).GetComponent<Text>();

        if (room_num == 1)
            ResultImage_1();
        else if (room_num == 2)
            ResultImage_2();
        else if (room_num == 3)
            ResultImage_3();
    }


    void ResultImage_1()
    {
        if (r1.Count > 0)
        {
            GameObject a;
            for (int i = 0; i < r1.Count; i++)
            {
                a = Instantiate(a_tmp, transform);
                a.transform.GetComponent<Image>().sprite = r1[i].artImage;

                if (r1[i].artPrice == null)
                {
                    a.transform.GetChild(0).GetComponent<Text>().text = "+   $ 0";
                }
                else
                {
                    a.transform.GetChild(0).GetComponent<Text>().text
                      = "+   $ " + GetThousandCommaText(r1[i].artPrice).ToString();
                }
            }
            Destroy(a_tmp);
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
    void ResultImage_2()
    {
        if (r2.Count > 0)
        {
            GameObject a;
            for (int i = 0; i < r2.Count; i++)
            {
                a = Instantiate(a_tmp, transform);
                a.transform.GetComponent<Image>().sprite = r2[i].artImage;

                if (r2[i].artPrice == null)
                {
                    a.transform.GetChild(0).GetComponent<Text>().text = "+   $ 0";
                }
                else
                {
                    a.transform.GetChild(0).GetComponent<Text>().text
                      = "+   $ " + GetThousandCommaText(r2[i].artPrice).ToString();
                }
            }
            Destroy(a_tmp);
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
    void ResultImage_3()
    {
        if (r3.Count > 0)
        {
            GameObject a;
            for (int i = 0; i < r3.Count; i++)
            {
                a = Instantiate(a_tmp, transform);
                a.transform.GetComponent<Image>().sprite = r3[i].artImage;

                if (r3[i].artPrice == null)
                {
                    a.transform.GetChild(0).GetComponent<Text>().text = "+   $ 0";
                }
                else
                {
                    a.transform.GetChild(0).GetComponent<Text>().text
                      = "+   $ " + GetThousandCommaText(r3[i].artPrice).ToString();
                }
            }
            Destroy(a_tmp);
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
    public string GetThousandCommaText(int data)
    {
        return string.Format("{0:#,###}", data);
    }
}
