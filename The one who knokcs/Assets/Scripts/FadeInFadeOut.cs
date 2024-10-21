using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public bool InFade = false;
    public bool OutFade = false;
    public float TimeToFade;

    void Start()
    {
        // Initialize canvasGroup.alpha to 0
        canvasGroup.alpha = 0f;
    }

    void Update()
    {
        if (InFade && canvasGroup.alpha < 1f)
        {
            canvasGroup.alpha += TimeToFade * Time.deltaTime;
            if (canvasGroup.alpha >= 1)
            {
                InFade = false;
            }
        }
        else if (OutFade && canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= TimeToFade * Time.deltaTime;
            if (canvasGroup.alpha <= 0)
            {
                OutFade = false;
            }
        }
    }

    public void FadeIn()
    {
        OutFade = false;
        InFade = true;
    }

    public void FadeOut()
    {
        InFade = false;
        OutFade = true;
    }
}