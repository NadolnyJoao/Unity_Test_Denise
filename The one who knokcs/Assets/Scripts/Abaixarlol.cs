using UnityEngine;

public class Abaixarlol : MonoBehaviour
{
    public GameObject parede;
    public GameObject parededois;
    public GameObject camer;
    private bool IsSneak;

    public void OnSneak()
    {

       
        if (IsSneak == true){
        parede.SetActive(false);
        parededois.SetActive(false);
        camer.transform.position -= new Vector3(0, 2, 0);
        }
        }
}