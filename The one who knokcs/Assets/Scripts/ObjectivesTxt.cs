using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectivesTxt : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ObjectivesTxts;
    public GameObject Book;
    public GameObject Lighet;
    public GameObject esqueiroTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Book){
        ObjectivesTxts.text = "Voce acordou em uma sala estranha, apenas com um livro na sua frente. Leia o Livro";}
        else if (Lighet.active){
        ObjectivesTxts.text = "O livro desaparece como magica, e um esqueiro aparece na sua frente. Tem velas apagadas por todo o quarto, o esqueiro pode ajudar.";
        }
        else if(esqueiroTxt.active){
        ObjectivesTxts.text = "Tente Acender as velas";
        }
    }
}
