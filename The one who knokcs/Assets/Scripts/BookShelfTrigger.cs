using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelfTrigger : MonoBehaviour
{
    public GameObject BookShelf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    void OnTriggerEnter(Collider other){
            Debug.Log("calabreso");
            BookShelf.transform.position = Vector3
        }
}
