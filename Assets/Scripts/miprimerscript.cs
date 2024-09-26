// Importamos las librerías necesarias para trabajar con Unity
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creamos una nueva clase llamada "miprimerscript" que hereda de MonoBehaviour
public class miprimerscript : MonoBehaviour //siempre crearlo en mayusculas la primera letra 
{
    // Declaramos una variable entera llamada "numeroDeSalto" y la inicializamos en 0
    int numeroDeSalto = 0;

    // Declaramos tres variables públicas enteras con valores iniciales
    public int primer = 5;
    public int segundo = 10;
    public int tercer = 15;
    // Las variables en C# no se inician en mayúsculas, la mayúscula va siempre después de la primera palabra
    // Ejemplo: pan cocido -> panCocido, si solo es una palabra todo en minúscula -> pan

    // El método Start se llama una única vez al inicio del juego
    void Start()
    {
        // Aquí podemos poner código que queremos que se ejecute al inicio
    }

    // El método Update se llama una vez por cada frame (fotograma)
    void Update()
    {
        // Aquí podemos poner código que queremos que se ejecute en cada frame
    }

    // El método OnCollisionEnter se llama cuando el objeto choca con otro objeto
    private void OnCollisionEnter(Collision collision) //se activa al impactar con algo, "collision" es una variable que sigue la misma regla, se inicia en minúscula
    {
        // Incrementamos la variable "numeroDeSalto" en 1 cada vez que ocurre una colisión
        numeroDeSalto = numeroDeSalto + 1; //le estamos solicitando que calcule y sume los datos dentro del entero "numeroDeSalto" con 1 

        // Mostramos un mensaje en la consola si "numeroDeSalto" es igual a "primer", "segundo" o "tercer"
        if (numeroDeSalto == primer || numeroDeSalto == segundo || numeroDeSalto == tercer)
        {
            Debug.Log(gameObject.name + " ha chocado un total de " + numeroDeSalto + " veces");
        }
        else
        {
            // Aquí podemos poner código para otros casos
        }

        // Podemos cambiar el tamaño del objeto con esta línea (comentada)
        // transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f); //sirve para cambiar el tamaño de un objeto 

        // Podemos reiniciar el contador con esta línea (comentada)
        // numeroDeSalto = 0; //reinicia el contador
    }
}

