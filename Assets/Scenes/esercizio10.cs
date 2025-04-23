using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio10 : MonoBehaviour
{
    private float tempoSuccessivaStampa = 0f;

    void Update()
    {
        if (Time.time >= tempoSuccessivaStampa)
        {
            tempoSuccessivaStampa = Time.time + 1f; // aspetta 1 secondo prima della prossima stampa

            float tempo = Time.time;

            if (tempo < 30f)
            {
                Debug.Log("sono trascorsi meno di 30 secondi");
            }
            else if (tempo > 60f)
            {
                Debug.Log("è trascorso più di un minuto");
            }
            else if (tempo > 45f)
            {
                Debug.Log("sono trascorsi più di 45 secondi");
            }
            else if (tempo > 30f)
            {
                Debug.Log("sono trascorsi più di 30 secondi");
            }
        }
    }
}