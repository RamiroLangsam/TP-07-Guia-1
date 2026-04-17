using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    string nombre = "ramiro";
    int edad = 15;
    float estatura = 177;
    bool esDonante = false;
    // Start is called before the first frame update
    void Start()
    {
        string mensajeDonante;
        if (esDonante) {
            mensajeDonante = "y soy donante ";
        }
        else {
            mensajeDonante = "No soy donante";
        }


        Debug.Log("mi nombre es " + nombre + ", tengo" + edad + "mi estatura es " + estatura + mensajeDonante);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
