using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio7 : MonoBehaviour
{
    public int partenza;

    void Start()
    {
        Stampa2Precedenti();
    }

    void Stampa2Precedenti()
    {
        Debug.Log("Numero di partenza: " + partenza);
        Debug.Log("Primo precedente: " + (partenza - 1));
        Debug.Log("Secondo precedente: " + (partenza - 2));
    }
}