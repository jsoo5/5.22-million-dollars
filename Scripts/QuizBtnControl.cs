using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizBtnControl : MonoBehaviour
{
    public GameObject quiz_window;
    
    [SerializeField]
    GameObject q1, q2;

    void Update()
    {
        if (quiz_window.active)
        {
            q1.SetActive(true);
        }

    }

        

    //q_btn.GetComponent<Button>();



    /*void Update()
    {
        //q_btn.onClick.AddListener(() => TextColorChange());
        //q_btn.onClick.AddListener(() => TextColorChange());
    }*/


    /*void TextColorChange()
    {
        q_text.color = new Color32(255, 255, 255, 255);
    }*/

}