using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    //Lista de eventos cargados en la escena
    Dictionary<string,Event> eventDictionary = new Dictionary<string, Event>();

    // Start is called before the first frame update
    //Inicializar la lista de eventos
    void Start()
    {
        StartEvent("EventInFall_Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //añadir un nuevo evento a la lista de eventos en escena
    //añadir su nombre a la lista de nombres de evento
    public void AddEvent(Event newEvent)
    {
        eventDictionary.Add(newEvent.eventName, newEvent);
    }

    public void StartEvent(string eventName)
    {
        Debug.Log("Call event: " + eventName);
        eventDictionary[eventName].StartEvent();
    }
}
