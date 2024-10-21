using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{

    FadeInFadeOut fade;


void Start() {
    fade = FindObjectOfType<FadeInFadeOut>();
    fade.FadeOut();
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
