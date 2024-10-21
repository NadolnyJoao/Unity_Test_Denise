using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField]float remaingTime;
    // Update is called once per frame
    void Update()
    {
        if (remaingTime >= 0){
            remaingTime -= Time.deltaTime;}
        else if (remaingTime<= 0){
            remaingTime = 0;
            
            Application.Quit();
        }
        int minutes = Mathf.FloorToInt(remaingTime /60);
        int seconds = Mathf.FloorToInt(remaingTime % 60);
        timerText.text = string.Format("{0:00}:{01:00}", minutes, seconds);
    }
}
