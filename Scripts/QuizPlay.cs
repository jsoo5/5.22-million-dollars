using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizPlay : MonoBehaviour
{
    public GameObject quiz;
    public GameObject room_number1, room_number2, room_number3;

    HelpManager helpManager;

    private void Start()
    {
        helpManager = GameObject.Find("Help Manager").GetComponent<HelpManager>();
    }
    private void Update()
    { 
        if (room_number1.active || room_number2.active || room_number3.active)
        {

            //CursorFixOff();            
            helpManager.help_num = 10;
        }
        else
        {
            helpManager.help_num = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Collider 1")
        {

            quiz.gameObject.SetActive(true);
            room_number1.gameObject.SetActive(true);
            //other.gameObject.SetActive(false);
                        
            Debug.Log("Quiz!");
        }
        else if (other.name == "Collider 2")
        {

            room_number2.gameObject.SetActive(true);
            //other.gameObject.SetActive(false);

            Debug.Log("Quiz!");
        }
        else if (other.name == "Collider 3")
        {

            room_number3.gameObject.SetActive(true);
            //other.gameObject.SetActive(false);

            Debug.Log("Quiz!");
        }
    }

    void CursorFixOn()
    {
        Cursor.visible = true;                     //마우스 커서가 보이지 않게 함
        Cursor.lockState = CursorLockMode.Locked;
    }

    void CursorFixOff()
    {
        Cursor.visible = true;                     //마우스 커서가 보이지 않게 함
        Cursor.lockState = CursorLockMode.None;
    }

    
    /*
    void QuizSetActive()
    {
        if (quiz.active)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1.0f;
            Debug.Log("Play");
        }
    }

    void Update()
    {
        QuizSetActive();
    }
    */

}
