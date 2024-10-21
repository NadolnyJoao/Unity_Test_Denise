using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelaInteraction : MonoBehaviour
{
    public GameObject VelaLuz;
    //public GameObject EsqueiroTxt;
    public Interactions interactions;
    public  int VelasOn;
    public GameObject[] gameObjects;
     public GameObject[] gameObjectsPaint;
    public bool AcendeuTudo = false;
    public bool Pinturas_Certas = false;
   
   


    // Update is called once per frame
    void Update()
    {
        
        gameObjects = GameObject.FindGameObjectsWithTag("Fire");

        if (gameObjects.Length == 6)
        {   
            AcendeuTudo = true;
           
           }
           gameObjectsPaint = GameObject.FindGameObjectsWithTag("Correct");

        if (gameObjectsPaint.Length == 3)
        {   
            Pinturas_Certas = true;
           
           }
    }
      public void Velas(){
        if(interactions.withEsqueiro){
        VelaLuz.SetActive(true);
        
        }
        }
    
}
