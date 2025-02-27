using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtManager : MonoBehaviour
{
    public static ArtManager Instance;

    public List<Art> stealRoom1 = new List<Art>();
    public List<Art> stealRoom2 = new List<Art>();
    public List<Art> stealRoom3 = new List<Art>();
    public string scoreTime;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void Add_1(Art art)
    {
        if (stealRoom1.Count < 5)
        {
            stealRoom1.Add(art);
        }
    }
    
    public void Remove_1(Art art)
    {
        stealRoom1.Remove(art);
    }

    public void Add_2(Art art)
    {
        if (stealRoom2.Count < 5)
        {
            stealRoom2.Add(art);
        }
    }

    public void Remove_2(Art art)
    {
        stealRoom2.Remove(art);
    }

    public void Add_3(Art art)
    {
        if (stealRoom3.Count < 5)
        {
            stealRoom3.Add(art);
        }
    }

    public void Remove_3(Art art)
    {
        stealRoom3.Remove(art);
    }
}
