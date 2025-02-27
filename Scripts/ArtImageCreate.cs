using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtImageCreate : MonoBehaviour
{
    /*public struct Arts
    {
        public string artName;
        public Sprite artImage;
        public int artPrice;
        public bool isTure;
        public bool isSelected;
    }*/

    public List<Art> arts = new List<Art>();

    List<Art> artInfo;
    
    void Start()
    {
        GameObject pic_tmp = transform.GetChild(0).gameObject;
        GameObject a;
        //.artInfo = pic_tmp.GetComponent<ArtSelect>().artInfo;
             
        //int i = Random.Range(0, room1.Count + 1);
        for (int i = 0; i < arts.Count; i++)
        {

            a = Instantiate(pic_tmp, transform);
            a.transform.GetComponent<Image>().sprite = arts[i].artImage;
            artInfo = a.GetComponent<ArtSelect>().artInfo;
            artInfo.Add(arts[i]);

        }

        Destroy(pic_tmp);
    }    
}
