using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio3 : MonoBehaviour
{
    public int voto;

    void Start()
    {
        string valutazione;

        if (voto == 10)
            valutazione = "A+";
        else if (voto == 9)
            valutazione = "A";
        else if (voto == 7 || voto == 8)
            valutazione = "B";
        else if (voto == 6)
            valutazione = "C";
        else if (voto == 5)
            valutazione = "E";
        else if (voto >= 0 && voto <= 4)
            valutazione = "F";
        else
            valutazione = "Valore non valido";

        Debug.Log("Il voto corrisponde a: " + valutazione);
    }
}