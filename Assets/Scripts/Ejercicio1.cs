using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    //Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.

    public int num1 = 0;
    public int num2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(num1 == num2)
        {
            Debug.Log("Los numeros " + num1 + " y " + num2 + " son iguales");
        }
        else
        {
            Debug.Log("Los numeros " + num1 + " y " + num2 + " no son iguales ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
