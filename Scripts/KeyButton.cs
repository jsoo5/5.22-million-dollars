using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyButton : MonoBehaviour, IPointerDownHandler
{
    public int[] keyButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        KeyManager.Instance.Add(keyButton);
    }
}
