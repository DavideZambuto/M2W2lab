using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio6 : MonoBehaviour
{
    public int partenza;

    void Start()
    {
        Stampa2Successivi();
    }

    void Stampa2Successivi()
    {
        Debug.Log("Numero di partenza: " + partenza);
        Debug.Log("Primo successivo: " + (partenza + 1));
        Debug.Log("Secondo successivo: " + (partenza + 2));
    }
}