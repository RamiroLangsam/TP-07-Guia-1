using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class El4 : MonoBehaviour
{
    public float num1 ;
    public float num2 ;

    void Start()
    {
        float suma = num1 + num2;
        float resta = num1 - num2;
        float multiplicacion = num1 * num2;
        float division = num1 / num2;

        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + suma);
        Debug.Log("El resultado de la resta entre " + num1 + " y " + num2 + " es: " + resta);
        Debug.Log("El resultado de la multiplicación entre " + num1 + " y " + num2 + " es: " + multiplicacion);
        Debug.Log("El resultado de la división entre " + num1 + " y " + num2 + " es: " + division);
    }

    void Update()
    {
        
    }
}