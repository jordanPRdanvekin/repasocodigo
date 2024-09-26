using System.Collections; // Esto permite usar colecciones b�sicas.
using System.Collections.Generic; // Esto permite usar colecciones m�s avanzadas.
using UnityEngine; // Esto permite usar las funciones de Unity.

public class coinBehavior : MonoBehaviour // Esta es la clase principal que controla el comportamiento de la moneda.
{
    public Vector3 speedRotation; // Esto es la velocidad a la que la moneda gira.

    // Start se llama al inicio del juego.
    void Start()
    {
        // Aqu� no hacemos nada al inicio.
    }

    // Update se llama una vez por cada cuadro del juego.
    void Update()
    {
        transform.Rotate(speedRotation * Time.deltaTime, Space.World);
        // Esto hace que la moneda gire.
        // Con Time.deltaTime, le decimos que gire a una velocidad constante, sin importar cu�ntos cuadros por segundo se est�n mostrando.
        // Con Space.World, le decimos que gire en el espacio del mundo, no sobre su propio eje.
    }
}

