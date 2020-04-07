using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeCollider : MonoBehaviour
{
    public Image blackScreen;
    private float time = .1f;

    void FadeToBlack()
    {
        blackScreen.color = Color.black;
        blackScreen.canvasRenderer.SetAlpha(0.0f);
        blackScreen.CrossFadeAlpha(1.0f, time, false);
    }

    void FadeFromBlack()
    {
        blackScreen.color = Color.black;
        blackScreen.canvasRenderer.SetAlpha(1.0f);
        blackScreen.CrossFadeAlpha(0.0f, time, false);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("FadeTrigger"))
        {
            Debug.Log("trigger hit");
            FadeToBlack();
        }
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("FadeTrigger"))
        {
            FadeFromBlack();
        }
    }
}
