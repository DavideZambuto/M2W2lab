using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio8 : MonoBehaviour
{
    public int a;
    public int b;

    void Start()
    {
        MaggioreTra2();
    }

    void MaggioreTra2()
    {
        int maggiore = (a > b) ? a : b;
        Debug.Log("Il valore maggiore tra i due è: " + maggiore);
    }
}
