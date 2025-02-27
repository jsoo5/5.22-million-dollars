using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArtSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    RectTransform rect;
    Outline highlighted;
    public bool isSelected = false;
    Vector3 origin;
    public List<Art> artInfo = new List<Art>();

    HelpManager helpManager;
    GameObject help_box;
    Animator help_anim;

    ItemController itemController;

    public GameObject box1, box2, box3;


    void Start()
    {

        helpManager = GameObject.Find("Help Manager").GetComponent<HelpManager>();
        help_box = GameObject.Find("help box");
        help_anim = help_box.GetComponent<Animator>();
        
        rect = gameObject.GetComponent<RectTransform>();
        highlighted = GetComponent<Outline>();
        highlighted.enabled = false;
        origin = rect.localScale;
    }

    public void Expanding()
    {
        highlighted.enabled = true;
        rect.localScale = origin * 1.1f;
    }

    public void Shrinking()
    {
        highlighted.enabled = false;
        rect.localScale = origin;
    }

    public void Selecting_1()
    {

        if (!isSelected)
        {
            if (ArtManager.Instance.stealRoom1.Count < 5)
            {
                isSelected = true;
                Debug.Log(artInfo[0].artName + " Select");
                ArtManager.Instance.Add_1(artInfo[0]);

                helpManager.help_num = 3;
                help_anim.SetTrigger("On");
            }
            else
            {
                //print("최대 5개까지만 선택할 수 있습니다");

                helpManager.help_num = 4;
                help_anim.SetTrigger("On");
                help_anim.SetTrigger("Off");
            }
        }

        else
        {
            isSelected = false;
            Debug.Log(artInfo[0].artName + " Not Select");
            ArtManager.Instance.Remove_1(artInfo[0]);
        }
    }

    public void Selecting_2()
    {

        if (!isSelected)
        {
            if (ArtManager.Instance.stealRoom2.Count < 5)
            {
                isSelected = true;
                Debug.Log(artInfo[0].artName + " Select");
                ArtManager.Instance.Add_2(artInfo[0]);

                helpManager.help_num = 3;
                help_anim.SetTrigger("On");
            }
            else
            {
                //print("최대 5개까지만 선택할 수 있습니다");

                helpManager.help_num = 4;
                help_anim.SetTrigger("On");
                help_anim.SetTrigger("Off");
            }
        }

        else
        {
            isSelected = false;
            Debug.Log(artInfo[0].artName + " Not Select");
            ArtManager.Instance.Remove_2(artInfo[0]);
        }
    }

    public void Selecting_3()
    {

        if (!isSelected)
        {
            if (ArtManager.Instance.stealRoom3.Count < 5)
            {
                isSelected = true;
                Debug.Log(artInfo[0].artName + " Select");
                ArtManager.Instance.Add_3(artInfo[0]);

                helpManager.help_num = 3;
                help_anim.SetTrigger("On");
            }
            else
            {
                //print("최대 5개까지만 선택할 수 있습니다");
                helpManager.help_num = 4;
                help_anim.SetTrigger("On");
                help_anim.SetTrigger("Off");
            }
        }

        else
        {
            isSelected = false;
            Debug.Log(artInfo[0].artName + " Not Select");
            ArtManager.Instance.Remove_3(artInfo[0]);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Expanding();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Shrinking();
    }


    void Update()    
    {
        if (isSelected)
        {
            Expanding();
        }
        else if ((box1.active && ArtManager.Instance.stealRoom1.Count == 0) 
            || (box2.active && ArtManager.Instance.stealRoom2.Count == 0)
            || (box3.active && ArtManager.Instance.stealRoom3.Count == 0))
        {
            helpManager.help_num = 3;
        }

        else if (InventoryManager.Instance.itemList[0].isUsing == true)
        {
            helpManager.help_num = 2;
        }
        else if (ArtManager.Instance.stealRoom1.Count > 0 
                && ArtManager.Instance.stealRoom2.Count > 0
                && ArtManager.Instance.stealRoom3.Count > 0)
        {
            helpManager.help_num = 9;
        }
        
    }
}
