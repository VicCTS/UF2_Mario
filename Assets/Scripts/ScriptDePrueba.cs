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

    public int[] arrayNumeros;

    private int[] arrayNumeros2 = new int[6];
    private int[] arrayNumeros3 = {7, 8, 3, 9};

    private string[] arrayStrings = new string[7];
    private string[] arrayStrings2 = {"Hola", "adios"};

    
    private int[,] array2Dimensiones = new int[4, 2];
    private int[,] array2Dimensiones2 = {{7, 8, 65, 0}, {9, 2, 545, 8}, {9, 6, 7, 7}};


    public List<string> stringList;


    private List<int> intList = new List<int>(7);
    private List<int> intList2 = new List<int>() {7, 9, 6, 78, 25, 0, 2, 8, 78};


    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log(arrayNumeros[1]);
        Debug.Log(arrayNumeros[0]);

        Debug.Log(array2Dimensiones2[0, 1]);

        arrayNumeros2[0] = 4;
        arrayNumeros2[5] = 7;

        array2Dimensiones2[2, 1] = 7777777;

        intList2.Add(10);
        intList2.Insert(5, 888);

        intList2.RemoveAt(2);
        intList2.Remove(0);

        intList2.Clear();
        */

        /*
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
        */

        /*
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        */


        /*
        int i = 0;
        while (i < 5)
        {
            Debug.Log(i);
            i++;
        }
        */

        /*
        int i = 10;
        do
        {
            Debug.Log(i);
            i++;
        } while (i < 5);
        */

        foreach (int numero in arrayNumeros3)
        {
            Debug.Log(numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
