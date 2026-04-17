using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int variableUno = 2;
    float variableDos = 4;
    string varibleTres = "Hola como estas";
    bool variableCuatro = true;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log(variableUno);
      Debug.Log(variableDos);
       Debug.Log(varibleTres);
        Debug.Log(variableCuatro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
