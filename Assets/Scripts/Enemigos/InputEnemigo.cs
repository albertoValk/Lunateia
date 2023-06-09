using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEnemigo : MonoBehaviour
{

    public Transform jugador;
    public float vertical {  get { return direccionHaciaJugador.y; } }
    public float horizontal { get { return direccionHaciaJugador.x; } }
    public float distancia { get { return direccionHaciaJugador.magnitude; } }
    public Vector2 direccionHaciaJugador { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        direccionHaciaJugador = jugador.position - transform.position;
        //  jugador = GameManager.instance.jugador.transform;
    }

    // Update is called once per frame
    void Update()
    {
        direccionHaciaJugador = jugador.position - transform.position;
    }
}
