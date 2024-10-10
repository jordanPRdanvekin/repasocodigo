// Importamos las librer�as necesarias para trabajar con Unity
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creamos una nueva clase llamada "miprimerscript" que hereda de MonoBehaviour
public class miprimerscript : MonoBehaviour //siempre crearlo en mayusculas la primera letra 
{
    // Declaramos una variable entera llamada "numeroDeSalto" y la inicializamos en 0
    int numeroDeSalto = 0;

    // Declaramos tres variables p�blicas enteras con valores iniciales
    public int primer = 5;
    public int segundo = 10;
    public int tercer = 15;
    // Las variables en C# no se inician en may�sculas, la may�scula va siempre despu�s de la primera palabra
    // Ejemplo: pan cocido -> panCocido, si solo es una palabra todo en min�scula -> pan

    // El m�todo Start se llama una �nica vez al inicio del juego
    void Start()
    {
        // Aqu� podemos poner c�digo que queremos que se ejecute al inicio
    }

    // El m�todo Update se llama una vez por cada frame (fotograma)
    void Update()
    {
        // Aqu� podemos poner c�digo que queremos que se ejecute en cada frame
    }

    // El m�todo OnCollisionEnter se llama cuando el objeto choca con otro objeto
    private void OnCollisionEnter(Collision collision) //se activa al impactar con algo, "collision" es una variable que sigue la misma regla, se inicia en min�scula
    {
        // Incrementamos la variable "numeroDeSalto" en 1 cada vez que ocurre una colisi�n
        numeroDeSalto = numeroDeSalto + 1; //le estamos solicitando que calcule y sume los datos dentro del entero "numeroDeSalto" con 1 

        // Mostramos un mensaje en la consola si "numeroDeSalto" es igual a "primer", "segundo" o "tercer"
        if (numeroDeSalto == primer || numeroDeSalto == segundo || numeroDeSalto == tercer)
        {
            Debug.Log(gameObject.name + " ha chocado un total de " + numeroDeSalto + " veces");
        }
        else
        {
            // Aqu� podemos poner c�digo para otros casos
        }

        // Podemos cambiar el tama�o del objeto con esta l�nea (comentada)
        // transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f); //sirve para cambiar el tama�o de un objeto 

        // Podemos reiniciar el contador con esta l�nea (comentada)
        // numeroDeSalto = 0; //reinicia el contador
    }
}

