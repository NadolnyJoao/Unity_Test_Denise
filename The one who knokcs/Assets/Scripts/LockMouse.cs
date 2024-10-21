using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockMouse : MonoBehaviour
{
  public GameObject Livro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Scene currentScene = SceneManager.GetActiveScene ();

		// Retrieve the name of this scene.
		string sceneName = currentScene.name;

		if (Livro.active) 
		{
			Cursor.lockState = CursorLockMode.None;
		}
    else{
      Cursor.lockState = CursorLockMode.Locked;
    }
    }
}
