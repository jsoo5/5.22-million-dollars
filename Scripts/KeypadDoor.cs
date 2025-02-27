using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadDoor : MonoBehaviour
{
    public GameObject keypad;
    GameObject player;
    float showDistance = 5.0f;

    HelpManager helpManager;
    GameObject help_box;
    Animator help_anim;

    private void Start()
    {
        helpManager = GameObject.Find("Help Manager").GetComponent<HelpManager>();
        help_box = GameObject.Find("help box");
        help_anim = help_box.GetComponent<Animator>();

        player = GameObject.Find("Player");
    }


    void OnMouseDown()
    {
        if (!keypad.active)
        {
            keypad.SetActive(true);
            helpManager.help_num = 5;

        }
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > showDistance)
        {
            keypad.SetActive(false);
            help_anim.SetTrigger("Off");
        }

        else if (keypad.active)
        {
            help_anim.SetTrigger("On");
        }

    }
}
