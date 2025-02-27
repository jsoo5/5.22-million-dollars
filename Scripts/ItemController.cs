using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemController : MonoBehaviour, IPointerDownHandler
{
    public List<Item> items = new List<Item>();
    GameObject flash;
    GameObject cam;
    
    HelpManager helpManager;
    GameObject help_box;
    Animator help_anim;


    void Start()
    {
        helpManager = GameObject.Find("Help Manager").GetComponent<HelpManager>();
        help_box = GameObject.Find("help box");
        help_anim = help_box.GetComponent<Animator>();

        cam = GameObject.Find("Main Camera");
        flash = cam.transform.GetChild(0).gameObject;
    }

    public void LightOn()
    {
        //if (items[0].itemName == "손전등")
        //{
            flash.SetActive(true);

            helpManager.help_num = 0;
            items[0].isUsing = false;

            Debug.Log("Item Flashlight");
        //}
    }

    public void Magnify()
    {
        //if (items[0].itemName == "돋보기")
        //{
            //Camera.main.fieldOfView = 20.0f;
            var camZoom = Camera.main.GetComponent<CamZoom>();
            camZoom.enabled = true;

            items[0].isUsing = true;

            Debug.Log("Item Magnifier");
            helpManager.help_num = 2;
            help_anim.SetTrigger("On");


        //print("마우스를 스크롤하여 화면을 확대할 수 있습니다.");

        //}
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (items[0].itemName == "손전등")
        {
            LightOn();

        }
        else if (items[0].itemName == "돋보기")
        {
            Magnify();
            help_anim.SetTrigger("Off");
            items[0].isUsing = false;
        }
    }


            /*private void Start()
            {
                //items = InventoryManager.Instance.items;
            }

            public void RemoveItem()
            {
                //InventoryManager.Instance.Remove(item);
                Destroy(gameObject);

                Debug.Log("Remove Item");
            }*/


}
