using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio5 : MonoBehaviour
{
    public int numero;
    // Start is called before the first frame update
    void Start()
    {
        string pariDispari = (numero % 2 == 0) ? "pari" : "dispari";
        string confronto = (numero > 10) ? "ed � maggiore di 10" : "ed � minore o uguale a 10";

        Debug.Log("Il numero � " + pariDispari + " " + confronto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
