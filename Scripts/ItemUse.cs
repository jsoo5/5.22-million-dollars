using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour
{
    
    Item item;
    public GameObject flash;

    void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        Destroy(gameObject);        
    }

}
