using UnityEngine;
using System.Collections;

public class NPCManager : MonoBehaviour {

    public enum Estado
    {
        IDLE,
        ANDAR,
        MUERTE
    }

    private Estado estadoActual = Estado.IDLE;
    private Estado estadoSiguiente = Estado.ANDAR;
    private Estado auxiliar; //borrar si se me ocurre otra cosa
    private float duracionEstado = 0f;
    private float tiempoEspera = 0f;
    private float velocidad = 0.5f;


	// Use this for initialization
	void Awake () {

        TiempoEstadoRandom();
	
	}

    void TiempoEstadoRandom ()
    {
        tiempoEspera = Random.Range(0.1f, 5.0f); // crea un nº random 
        //Debug.Log("Ha creado tiempo de espera: " + tiempoEspera);
    }
	
	// Update is called once per frame
	void Update () {
        duracionEstado += Time.deltaTime;

        if (duracionEstado >= tiempoEspera)
        {
            //Debug.Log("se ha cumplido el tiempo de espera");
            duracionEstado = 0f;
            TiempoEstadoRandom();
            auxiliar = estadoActual;
            estadoActual = estadoSiguiente;
            estadoSiguiente = auxiliar;
            //Debug.Log("estadoActual: " + estadoActual + " estadoSiguiente: " + estadoSiguiente);
        }

        switch (estadoActual)
        {
            case Estado.IDLE:
                break;
            case Estado.ANDAR:
                transform.position += Vector3.right * velocidad * Time.deltaTime;
                break;
            case Estado.MUERTE:
                break;
            default:
                break;
        }
	
	}
}
