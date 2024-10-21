using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintsChalange : MonoBehaviour
{
    public Transform Up;
    public Transform Down;
    public Transform Left;
    public Transform Right;
    public Transform Paint;
    public GameObject Pintura;
    public GameObject[] gameObjects;
    public GameObject Chave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Up.transform.position == Paint.transform.position && Pintura.tag == "UpArrow"){
        
        Pintura.tag = "Correct";
    }  
     if (Down.transform.position == Paint.transform.position && Pintura.tag == "DownArrow"){
        
        Pintura.tag = "Correct";
    }  
     if (Left.transform.position == Paint.transform.position && Pintura.tag == "LeftArrow"){
        
        Pintura.tag = "Correct";
    }  
     if (Right.transform.position == Paint.transform.position && Pintura.tag == "RightArrow"){
        
        Pintura.tag = "Correct";
    }  
    gameObjects = GameObject.FindGameObjectsWithTag("Correct");

        if (gameObjects.Length == 3)
        {   
           //Chave.SetActive(true);
           }
    
    
    }
   
}
