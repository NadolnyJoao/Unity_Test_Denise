using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    FadeInFadeOut fade;
    public Slider VolumeSlidr;


    void Start()
    {
        fade = FindObjectOfType<FadeInFadeOut>();
    }
    public IEnumerator ChangeScene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("TheRoom");
    }
    public void StartGame()
    {
        StartCoroutine(ChangeScene());
    }

    public void ExitGame()
    {
        Application.Quit();
        //EditorApplication.Exit(0);
    }
    
}
