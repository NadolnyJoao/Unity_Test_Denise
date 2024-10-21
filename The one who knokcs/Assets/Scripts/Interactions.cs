using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public GameObject Esqueiro; 
    public GameObject EsqueiroON;
    public GameObject VelaLuz;
    public bool withEsqueiro = false;
    public GameObject[] gameObjects;
    int temp;

    
    // Start is called before the first frame update
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         gameObjects = GameObject.FindGameObjectsWithTag("Fire");

        if (gameObjects.Length == 6 && temp == 1)
        {   
            Esqueiro.SetActive(false);
            temp = 2;
           }
    }
    public void OnEsqueiro(){
        Esqueiro.SetActive(false);
        EsqueiroON.SetActive(true);
        withEsqueiro = true;
    }
    
}
