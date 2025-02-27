using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetEffect : MonoBehaviour
{
    public GameObject getEffect;

    private void Update()
    {
        if (getEffect.active)
        {
            StartCoroutine(ItemEffectOff());
        }
    }

    IEnumerator ItemEffectOff()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        getEffect.SetActive(false);

        Debug.Log("Effect Off");
    }
}
