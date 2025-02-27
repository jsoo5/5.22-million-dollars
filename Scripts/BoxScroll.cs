using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxScroll : MonoBehaviour
{
    public ScrollRect scrollRect;
    //public RectTransform content;
    public float move = -1.0f;
   
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    public void Next()
    {
        scrollRect.horizontalNormalizedPosition -= move;
    }

    public void Prev()
    {
        scrollRect.horizontalNormalizedPosition += move;
    }
}
