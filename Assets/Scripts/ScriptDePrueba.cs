using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDePrueba : MonoBehaviour
{

    public int vidasPersonaje = 5;
    public int vidasPersonaje2 = 3;
    public float numeroDecimal = 4.5f;
    public string nombrePersonaje = "Nombre de nuestro personaje";
    public char letra = 'a';
    private bool interruptor = false;

    // Start is called before the first frame update
    void Start()
    {
        vidasPersonaje = 10;
        numeroDecimal = 7.54f;
        nombrePersonaje = "asfdasdf";
        interruptor = true;

        int suma = vidasPersonaje + vidasPersonaje2;
        Debug.Log(suma);
        string sumaTextos = nombrePersonaje + "qqqqqqqqqqqqqqqqqqqq";
        Debug.Log(sumaTextos);


        Debug.Log(nombrePersonaje);
        Debug.Log(vidasPersonaje);
        Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
