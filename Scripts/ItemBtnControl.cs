using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBtnControl : MonoBehaviour
{
    public GameObject inventory;

     public void InventorySetActive()
    {
        inventory.SetActive(!inventory.active);
    }
}
