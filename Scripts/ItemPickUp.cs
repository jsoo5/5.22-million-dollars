using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickUp : MonoBehaviour
{
    public Item item;
    public List<Item> getItems;

    public Transform ItemContent;
    public GameObject InventoryItem;
    public GameObject Inventory;
    public GameObject getEffect;
    public GameObject box1, box2, box3;

    void Pickup()
    {
        InventoryManager.Instance.Add(item);
        Destroy(gameObject);
    }

    void ItemBoxCreate()
    {
        GameObject b = Instantiate(InventoryItem, ItemContent);
        getItems = b.AddComponent<ItemController>().items;
        Image itemIcon = b.transform.Find("icon").GetComponent<Image>();
        itemIcon.sprite = item.itemIcon;

        getItems.Add(item);
        Debug.Log("Get Item");

        getEffect.SetActive(true);
        Image get_img = getEffect.transform.Find("Item Image").GetComponent<Image>();
        Text get_txt = getEffect.transform.Find("Text").GetComponent<Text>();
        get_img.sprite = item.itemIcon;
        get_txt.text = item.itemName + " æ∆¿Ã≈€ »πµÊ!";
        
        if (box1.active || box2.active || box3.active)
        {
            box1.SetActive(false);
            box2.SetActive(false);
            box3.SetActive(false);
        }
    }

    public void OnMouseDown()
    {
        if (!InventoryItem.active)
        {
            Inventory.SetActive(true);
            InventoryItem.SetActive(true);
            
        }

        /*if (!InventoryItem.active)
        {
            InventoryItem.SetActive(true);
            Inventory.SetActive(true);
            Image itemIcon_ = InventoryItem.transform.Find("icon").GetComponent<Image>();
            itemIcon_.sprite = item.itemIcon;

            getItems.Add(item);
            Debug.Log("Get Item");

            getEffect.SetActive(true);
            Image get_img = getEffect.transform.Find("Item Image").GetComponent<Image>();
            Text get_txt = getEffect.transform.Find("Text").GetComponent<Text>();
            get_img.sprite = item.itemIcon;
            get_txt.text = item.itemName + " æ∆¿Ã≈€ »πµÊ!";  
        }*/

        ItemBoxCreate();

        Pickup();

        InventoryItem.SetActive(false);
        
    }

}
