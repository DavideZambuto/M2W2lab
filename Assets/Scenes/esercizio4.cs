using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esercizio4 : MonoBehaviour
{
    public int numero1;    
    public int numero2;
    public int numero3;
    public int numero4; 
    // Start is called before the first frame update
    void Start()
    {
        int somma = numero1 + numero2 + numero3 + numero4;
        int prodotto = numero1 * numero2 * numero3 * numero4;
        float media = somma / 4f;

        Debug.Log("Somma: " + somma);
        Debug.Log("Prodotto: " + prodotto);
        Debug.Log("Media: " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
