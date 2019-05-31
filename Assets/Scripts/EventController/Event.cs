using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public string eventName;

    public Event()
    {
        
    }

    public virtual void StartEvent()
    {
        Debug.LogError("Evento \"" + eventName + "\" no encontrado");
    }

   
}
