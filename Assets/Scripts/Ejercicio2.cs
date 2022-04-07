using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    //Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
    //Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

    public float precio1 = 0;
    public float precio2 = 0;
    public float precio3 = 0;
    public float montoDisponible = 0;
    float montoT = 0;
    // Start is called before the first frame update
    void Start()
    {
        montoT = precio1 + precio2 + precio3;
        if(montoDisponible < montoT)
        {
            Debug.Log("El costo total de los tres productos supera el presupuesto por: $" + (montoT - montoDisponible));
        }
        else if(montoDisponible == montoT)
        {
            Debug.Log("El costo total de los tres productos es igual al presupuesto");
        }
        else
        {
            Debug.Log("El costo total de los tres productos no supera el presupuesto por: $" + (montoDisponible - montoT));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
