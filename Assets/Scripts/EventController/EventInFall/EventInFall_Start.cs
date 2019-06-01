using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInFall_Start : Event
{

    public GameObject player;       //Prefab del jugador
    private Vector2 playerVelocity = Vector2.one; //variable necesaria para el SmoothDamp

    public GameObject spawnPoint;   //Punto en el que aparece el jugador al iniciar la escena
    public GameObject startPoint;   //Punto hasta donde se desplaza el jugador antes de iniciar el juego
    private bool eventInPlay = false;


    // Start is called before the first frame update
    void Awake()
    {
        this.GetComponentInParent<EventController>().AddEvent(this);
    }

    void LateUpdate()
    {
        if (eventInPlay)
        {
            player.transform.position = Vector2.SmoothDamp(player.transform.position, startPoint.transform.position, ref playerVelocity, 1.5f);
            if (player.transform.position.y <= startPoint.transform.position.y + 0.5f )
            {
                eventInPlay = false;
                player.GetComponent<PlayerMovementInFall>().EnableMove(true);
            }
        }
        
    }

    public override void StartEvent()
    {
        eventInPlay = true;
        player.GetComponent<PlayerMovementInFall>().EnableMove(false);
        player.transform.position = spawnPoint.transform.position;
    }
}
