using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> itemList = new List<Item>();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        itemList.Add(item);
    }

    public void Remove(Item item)
    {
        itemList.Remove(item);
    }


    /*public void LightOn()
    {
        foreach (Item item in itemList)
        {
            if (item.itemName == "������")
            {
                flash.SetActive(true);
        
                Debug.Log("Item Flashlight");
            }
        }

    }

    public void Magnify()
    {
        foreach (Item item in itemList)
        {
            if (item.itemName == "������")
            {
                //Camera.main.fieldOfView = 20.0f;
                var camZoom = Camera.main.GetComponent<CamZoom>();
                camZoom.enabled = true;

                Debug.Log("Item Magnifier");
        
                print("���콺�� ��ũ���Ͽ� ȭ���� Ȯ���� �� �ֽ��ϴ�.");
                
            }
        }

    }*/


    /*switch (item.itemType)
    {
        case Item.ItemType.Flashlight:
            LightOn();
            break;
        case Item.ItemType.Magnifier:
            Magnify();
            break;
    }*/


}
