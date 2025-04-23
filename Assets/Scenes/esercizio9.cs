using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio9 : MonoBehaviour
{
    public int a;
    public int b;

    void Start()
    {
        MaggioreTra2();
    }

    void MaggioreTra2()
    {
        int minore = (a < b) ? a : b;
        Debug.Log("Il valore minore tra i due è: " + minore);

    }
}
