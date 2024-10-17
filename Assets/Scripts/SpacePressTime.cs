using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpacePressTime : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI EspaTime; // Muestra el tiempo entre pulsaciones
    [SerializeField]
    TextMeshProUGUI Cantida; // Muestra el número de veces pulsado
    [SerializeField]
    TextMeshProUGUI Mins; // Muestra la estimación de pulsaciones por minuto

    public bool tiemp;
    public float contar = 0.0f;  // inicializamos el contador a 0
    public int numero = 0;
    private float TiemEntPul = 0.0f; // para almacenar el tiempo de la última pulsación
    private float VecesPulsado = 0.0f; // para almacenar el tiempo total entre pulsaciones
    private int QuinceSecs = 0;  // contador de pulsaciones para 15 segundos
    private float Inicio = 0.0f;  // para almacenar el tiempo de inicio

    // Método Start que se llama antes de la primera actualización del frame
    void Start()
    {
        EspaTime.text = "0"; // Inicializamos el texto de EspaTime a "0"
        Cantida.text = "0"; // Inicializamos el texto de Cantida a "0"
        Mins.text = "0"; // Inicializamos el texto de Mins a "0"
        Inicio = Time.time; // Guardamos el tiempo de inicio
    }

    // Método Update que se llama una vez por frame
    void Update()
    {
        // Si se pulsa la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numero += 1; // Incrementamos el número de pulsaciones
            tiemp = !tiemp; // Alternamos el estado de tiemp entre verdadero y falso

            if (!tiemp) // Si tiemp es falso, mostramos el tiempo entre pulsaciones
            {
                float pressTime = Time.time - TiemEntPul; // Calculamos el tiempo desde la última pulsación
                EspaTime.text = pressTime.ToString("0.0"); // Mostramos el tiempo con 1 decimal
                VecesPulsado += pressTime; // Sumamos el tiempo al total
                QuinceSecs++; // Incrementamos el contador de pulsaciones
            }

            TiemEntPul = Time.time; // Actualizamos el tiempo de la última pulsación
        }

        if (tiemp) // Si tiemp es verdadero, comenzamos a contar los segundos
        {
            contar += Time.deltaTime; // Incrementamos el contador con el tiempo delta
            EspaTime.text = contar.ToString("0.0"); // Mostramos el contador con 1 decimal
        }

        // Si han pasado 15 minutos (900 segundos), mostramos el número de pulsaciones
        if (Time.time - Inicio >= 900.0f)
        {
            Cantida.text = numero.ToString(); // Mostramos el número de pulsaciones en Cantida
        }

        // Calculamos y mostramos la estimación de pulsaciones por minuto basándonos en las pulsaciones de los primeros 15 segundos
        if (QuinceSecs > 0 && VecesPulsado <= 15.0f)
        {
            float pressesPerMinute = (QuinceSecs / VecesPulsado) * 60.0f; // Calculamos las pulsaciones por minuto
            Mins.text = pressesPerMinute.ToString("0.0"); // Mostramos la estimación con 1 decimal
        }
    }
}

