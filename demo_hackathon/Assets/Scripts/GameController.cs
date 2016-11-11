using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    //Coger alto de la pantalla, dividirlo entre los personajes (los jugadores + 20)
    private int numeroTotalPersonajes = 8;
    private int espacioVerticalEntrePj = 1; //calcular según la cantidad de personajes y el alto de la escena
    private SpriteRenderer sprite;
    public GameObject npc;
    

	// Use this for initialization
	void Start () {
        

        for (int i = 0; i < numeroTotalPersonajes; i++)
        {
            Instantiate(npc);
            npc.transform.position = new Vector3(0, 5-espacioVerticalEntrePj*i); //cambiar por el margen inferior
            sprite = npc.GetComponent<SpriteRenderer>();
            sprite.sortingOrder = i;
            Debug.Log(npc.transform.position);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
