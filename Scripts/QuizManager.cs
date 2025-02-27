using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public Button wrong_btn;
    public GameObject q_window;

    Animation effect;
    bool isCorrect = false;

    void Start()
    {
        wrong_btn = GetComponent<Button>();
        effect = q_window.GetComponent<Animation>();
    }

    
    public void WrongAnswer()
    {
        
        effect.Play("WrongAnswer");
        Debug.Log("Incorrect");
    }

    void Update()
    {
        wrong_btn.onClick.AddListener(WrongAnswer);     
        //q_window.color = new Color32(0, 255, 0, 255);

    }

}
