using System.Collections; // Esto permite usar colecciones básicas.
using System.Collections.Generic; // Esto permite usar colecciones más avanzadas.
using UnityEngine; // Esto permite usar las funciones de Unity.
using TMPro;

public class playerBehavior : MonoBehaviour // Esta es la clase principal que controla el comportamiento del jugador.
{
    Rigidbody rb; // Esto es como el esqueleto del jugador que permite moverse.
    public int salto = 10; // Esta es la fuerza con la que el jugador salta.
    public int movimiento = 20; // Esta es la velocidad con la que el jugador se mueve.
    public int coinobtained = 0; //esta es la variable de cantidad de monedas.
    public TextMeshProUGUI coinstxt;
    public AudioClip pickupcoin;
    public AudioClip spickupcoin;

    // Start se llama al inicio del juego.
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Aquí le decimos al esqueleto que se conecte al jugador.
    }

    // Update se llama una vez por cada cuadro del juego.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Si se presiona la barra espaciadora...
        {
            rb.AddForce(transform.up * salto, ForceMode.Impulse); // ...el jugador salta hacia arriba.
        }
        Vector3 mover = new Vector3(); // Creamos un nuevo vector para el movimiento.
        mover.x = Input.GetAxis("Horizontal"); // Movemos al jugador a la izquierda o derecha.
        mover.z = Input.GetAxis("Vertical"); // Movemos al jugador hacia adelante o atrás.
        rb.AddForce(mover * Time.deltaTime, ForceMode.Impulse); // Aplicamos el movimiento al jugador.
    }

    // Esto se llama cuando el jugador toca otro objeto.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin")) // Si el jugador toca una moneda...
        {
            coinobtained++; //++ = sumar 1 es decir coinobtained = coinobtained + 1; pero en formato de atajo
            Debug.Log("eh tocado la moneda comun obteniendo " + coinobtained + " monedas hoy "); // ...mostramos un mensaje en la consola.
            AudioSource.PlayClipAtPoint(pickupcoin, transform.position);
        }
        else if (other.CompareTag("specialcoin")) // Si el jugador toca una moneda especial...
        {
            coinobtained += 5; //es el equivalente a poner coinontained =  coinobtained + 5; pero mas breve
            Debug.Log("eh tocado la moneda especial obteniendo " + coinobtained + " monedas hoy "); // ...mostramos un mensaje en la consola.
            AudioSource.PlayClipAtPoint(spickupcoin, transform.position);
        }
        if (other.tag.Contains("coin"))
        {
            coinstxt.text = coinobtained.ToString();
        other.gameObject.SetActive(false);
            
        }
    }
}

