using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ArrastarPinturas : MonoBehaviour
{
   /* public Transform UpTarget;
    public Transform DownTarget;
    public Transform LeftTarget;
    public Transform RightTarget;*/
    public float Speed ;
    public GameObject Quadro;
    public GameObject UpRef;
    public GameObject DownRef;
    public GameObject LeftRef;
    public GameObject RightRef;
    public bool UpChal;
    public bool DownChal;
    public bool LeftChal;
    public bool RightChal;
    
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //activates when the player moves the paint up, down, left or right
    public void OnPaintUp(){
       Quadro.transform.position = UpRef.transform.position;

    }
     public void OnPaintDown(){
        Quadro.transform.position = DownRef.transform.position;

    }
     public void OnPaintLeft(){
        Quadro.transform.position = LeftRef.transform.position;

    }
     public void OnPaintRight(){
       Quadro.transform.position = RightRef.transform.position;

    }

}
