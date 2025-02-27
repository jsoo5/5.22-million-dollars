using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    List<Art> r1, r2, r3;
    List<Item> itemList;
    public GameObject room_1, room_2, room_3, room_4;
    /*
    // Image
    GameObject a_tmp_1, a_tmp_2, a_tmp_3;
    public GameObject arts_1, arts_2, arts_3;

    // F/S Box
    public Sprite fail;
    public Sprite success;
    GameObject b_tmp_1, b_tmp_2, b_tmp_3;
    public GameObject box_1, box_2, box_3;
    */
    // Price
    private int _1, _2, _3, _4;
    public GameObject monaLisa;

    public GameObject sum_1, sum_2, sum_3;
    Text sum_1_txt, sum_2_txt, sum_3_txt;
    public Text sum_4_txt;
    
    private int p;
    public GameObject totalPrice;
    Text total_txt;

    // Time
    float elapsedTime;
    Text time_txt;

    private void Start()
    {
        GameObject am = GameObject.Find("Art Manager");
        GameObject im = GameObject.Find("Inventory Manager");
        GameObject totalTime = GameObject.Find("Total Time");

        itemList = im.GetComponent<InventoryManager>().itemList;
        total_txt = totalPrice.GetComponent<Text>();
        time_txt = totalTime.GetComponent<Text>();

        r1 = am.GetComponent<ArtManager>().stealRoom1;
        r2 = am.GetComponent<ArtManager>().stealRoom2;
        r3 = am.GetComponent<ArtManager>().stealRoom3;
        /*
        a_tmp_1 = arts_1.transform.GetChild(0).gameObject;
        a_tmp_2 = arts_2.transform.GetChild(0).gameObject;
        a_tmp_3 = arts_3.transform.GetChild(0).gameObject;

        b_tmp_1 = box_1.transform.GetChild(0).gameObject;
        b_tmp_2 = box_2.transform.GetChild(0).gameObject;
        b_tmp_3 = box_3.transform.GetChild(0).gameObject;
        */
        sum_1_txt = sum_1.GetComponent<Text>();
        sum_2_txt = sum_2.GetComponent<Text>();
        sum_3_txt = sum_3.GetComponent<Text>();

        ResultPrice_1();
        ResultPrice_2();
        ResultPrice_3();
        ResultPrice_4();
        ResultTotal();

        elapsedTime = PlayerPrefs.GetFloat("elapsed time");
        //string elapsedTime = string.Format("{0:00:}{1:00:}{2:00}", hour, min, sec);
        //time_txt.text = elapsedTime.ToString();
        time_txt.text = ArtManager.Instance.scoreTime;

        StartCoroutine("ShowDelay");
    }
    IEnumerator ShowDelay()
    {
        yield return new WaitForSecondsRealtime(1.0f);
            room_1.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
            room_2.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
            room_3.SetActive(true);
        yield return new WaitForSecondsRealtime(1.0f);
            room_4.SetActive(true);
        yield return new WaitForSecondsRealtime(2.0f);
            totalPrice.SetActive(true);
        yield return new WaitForSecondsRealtime(3.0f);
        
        if (p >= 5220000)
        {
            SceneManager.LoadScene("Ending_success");
        }
        else
        {
            SceneManager.LoadScene("Ending_fail");
        }
    }


    public void ResultPrice_1()
    {
        if (r1.Count > 0)
        {
            for (int i = 0; i < r1.Count; i++)
            {
                _1 += r1[i].artPrice;
            }

            sum_1_txt.text = "$ " + GetThousandCommaText(_1).ToString();
        }
        else
        {
            sum_1_txt.text = "$ 0";
            Debug.Log("r1 is NULL");
        }
    }
    public void ResultPrice_2()
    {
        if (r2.Count > 0)
        {
            for (int i = 0; i < r2.Count; i++)
            {
                _2 += r2[i].artPrice;
            }

            sum_2_txt.text = "$ " + GetThousandCommaText(_2).ToString();
        }

        else
        {
            sum_2_txt.text = "$ 0";
            Debug.Log("r2 is NULL");
        }
    }
    public void ResultPrice_3()
    {
        if (r3.Count > 0)
        {
            for (int i = 0; i < r3.Count; i++)
            {
                _3 += r3[i].artPrice;
            }

            sum_3_txt.text = "$ " + GetThousandCommaText(_3).ToString();
        }

        else
        {
            sum_3_txt.text = "$ 0";
            Debug.Log("r3 is NULL");
        }
    }
    public void ResultPrice_4()
    {
        if (itemList.Count > 0)
        {
            foreach (var item in itemList)
            {
                if (item.itemName == "모나리자")
                {
                    _4 = 1000000;
                    sum_4_txt.text = "+       $ " + GetThousandCommaText(_4).ToString();
                    Debug.Log("MonaLisa");
                }
            }
        }
        else
        {
            _4 = 0;
            monaLisa.SetActive(false);
            sum_4_txt.text = "$ 0";
            Debug.Log("r4 is NULL");
        }
    }
    void ResultTotal()
    {
        p = _1 + _2 + _3 + _4;

        if (p > 0)
        {
            total_txt.text = "Total   $ " + GetThousandCommaText(p).ToString();
        }
        else
        {
            total_txt.text = "Total  $ 0";
            Debug.Log("total is NULL");
        }
    }

    public string GetThousandCommaText(int data)
    {
        return string.Format("{0:#,###}", data);
    }
}

    /*
    void ResultBox_1()
    {
        if (r1.Count > 0)
        {
            box_1.SetActive(true);
            GameObject b;
            for (int i = 0; i < r1.Count; i++)
            {
                b = Instantiate(b_tmp_1, transform);

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
            Destroy(b_tmp_1);
        }
        else
        {
            box_1.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
    void ResultBox_2()
    {
        if (r2.Count > 0)
        {
            box_2.SetActive(true);
            GameObject b;
            for (int i = 0; i < r2.Count; i++)
            {
                b = Instantiate(b_tmp_2, transform);

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
            Destroy(b_tmp_2);
        }
        else
        {
            box_2.SetActive(false);
            Debug.Log("r2 is NULL");
        }
    }
    void ResultBox_3()
    {
        if (r3.Count > 0)
        {
            box_3.SetActive(true);
            GameObject b;
            for (int i = 0; i < r3.Count; i++)
            {
                b = Instantiate(b_tmp_3, transform);

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
            Destroy(b_tmp_3);
        }
        else
        {
            box_3.SetActive(false);
            Debug.Log("r3 is NULL");
        }
    }
    void ResultImage_1()
    {
        if (r1.Count > 0)
        {
            arts_1.SetActive(true);
            GameObject a;
            for (int i = 0; i < r1.Count; i++)
            {
                a = Instantiate(a_tmp_1, transform);
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
            Destroy(a_tmp_1);
        }
        else
        {
            arts_1.SetActive(false);
            Debug.Log("r1 is NULL");
        }
    }
    void ResultImage_2()
    {
        if (r2.Count > 0)
        {
            arts_2.SetActive(true);
            GameObject a;
            for (int i = 0; i < r2.Count; i++)
            {
                a = Instantiate(a_tmp_2, transform);
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
            Destroy(a_tmp_2);
        }
        else
        {
            arts_2.SetActive(false);
            Debug.Log("r2 is NULL");
        }
    }
    void ResultImage_3()
    {
        if (r3.Count > 0)
        {
            arts_3.SetActive(true);
            GameObject a;
            for (int i = 0; i < r3.Count; i++)
            {
                a = Instantiate(a_tmp_3, transform);
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
            Destroy(a_tmp_3);
        }
        else
        {
            arts_3.SetActive(false);
            Debug.Log("r3 is NULL");
        }
    }
    */