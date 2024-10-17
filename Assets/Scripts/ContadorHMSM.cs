using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorHMSM : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tiempo; // Declara una variable pública que se puede asignar desde el editor de Unity para mostrar el tiempo en pantalla

    public bool time; // Declara una variable pública que indica si el contador está activo o no
    public float contar = 0.0f; // Declara una variable pública que almacena el tiempo transcurrido

    // Start is called before the first frame update
    void Start() // Método que se llama una vez al inicio del juego
    {
        tiempo.text = "0:00:00:000"; // Establece el texto inicial del contador a "0:00:00:000"
    }

    // Update is called once per frame
    void Update() // Método que se llama una vez por cada frame del juego
    {
        if (time) // Comprueba si el contador está activo
        {
            contar += Time.deltaTime; // Incrementa el tiempo transcurrido en la cantidad de tiempo que ha pasado desde el último frame
            tiempo.text = FormatearTiempo(contar); // Actualiza el texto del contador con el tiempo formateado
        }
        string FormatearTiempo(float tiempo) // Método privado que convierte el tiempo transcurrido en un formato de texto legible
        {
            float horas = (tiempo / 3600); // Calcula las horas dividiendo el tiempo total por 3600 (segundos en una hora ya que son 60 minutos por 60 segundos = 60 x 60 = 3600)
            float minutos = (int)((tiempo % 3600) / 60); // Calcula los minutos restantes dividiendo el tiempo restante por 60 (segundos en un minuto es importante hacerlo de esta forma ya que queremos que divida la hora por los minutos )
            float segundos = (int)(tiempo % 60); // Calcula los segundos restantes dividiendo los minutos por los segundos dentro de un minuto
            float milisegundos = (int)((tiempo * 1000) % 1000); // Calcula los milisegundos restantes transformandolos primero en milisegundos y luego dividiendolos por 1000 para sacar el restante
            return horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00") + ":" + milisegundos.ToString("000"); // Devuelve el tiempo formateado como una cadena de texto es importante poner los 0 pues le dice al texto cuantas cifras debera mostrar 
        }
    }

    // Función para pausar o reanudar el contador
    public void Pausa() // Método público que se puede llamar para pausar o reanudar el contador
    {
        time = !time; // Cambia el estado del contador: si está activo, lo pausa; si está pausado, lo activa
    }

    // Función para reiniciar el contador
    public void Stop() // Método público que se puede llamar para reiniciar el contador
    {
        time = false; // Pausa el contador
        contar = 0.0f; // Reinicia el tiempo transcurrido a 0
        tiempo.text = "0:00:00:00"; // Reinicia el texto del contador a "0:00:00:00"
    }



}
