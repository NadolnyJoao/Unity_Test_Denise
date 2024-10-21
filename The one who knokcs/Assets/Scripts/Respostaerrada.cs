using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respostaerrada : MonoBehaviour
{
    public GameObject FailScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnFail(){
        FailScreen.SetActive(true);

    }
}
