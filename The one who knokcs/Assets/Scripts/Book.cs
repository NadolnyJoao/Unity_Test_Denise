using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Book : MonoBehaviour
{
    void start(){

        Cursor.lockState = CursorLockMode.None;
    }
    public void BoraBill(){
        

    }
    public void Amostrado(){

    }
    public void Back(){
        SceneManager.LoadScene("TheRoom");

    }

}
