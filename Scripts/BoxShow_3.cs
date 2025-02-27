using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxShow_3 : MonoBehaviour
{
    float showDistance = 5.0f;
    float offDistance = 18.0f;
    private GameObject player;
    public GameObject[] arts;

    public GameObject selectBox;
    public GameObject item;

    HelpManager helpManager;
    GameObject help_box;
    Animator help_anim;


    void Start()
    {
        helpManager = GameObject.Find("Help Manager").GetComponent<HelpManager>();
        help_box = GameObject.Find("help box");
        help_anim = help_box.GetComponent<Animator>();

        player = GameObject.Find("Player");
        arts = GameObject.FindGameObjectsWithTag("Room_3");

        selectBox.SetActive(false);
    }

    void Update()
    {
        for (int i = 0; i < arts.Length; i++)
        {
            if (Vector3.Distance(arts[i].transform.position, player.transform.position) <= showDistance
                && item.active)
            {
                selectBox.SetActive(true);
                help_anim.SetTrigger("On");

            }
            else if (Vector3.Distance(arts[i].transform.position, player.transform.position) <= showDistance
                     && !item.active)
            {
                selectBox.SetActive(false);
                //print("작품을 보기 위해서 손전등이 필요합니다.");

                helpManager.help_num = 1;
                help_anim.SetTrigger("On");

                Debug.Log("Find flash");
            }
            else if ((Vector3.Distance(arts[1].transform.position, player.transform.position) > offDistance)
                || (Vector3.Distance(arts[2].transform.position, player.transform.position) > offDistance))
            {
                selectBox.SetActive(false);
                //helpManager.help_num = 7;
                help_anim.SetTrigger("Off");
            }

        }
    }
}
