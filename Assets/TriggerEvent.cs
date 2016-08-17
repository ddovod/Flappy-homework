using UnityEngine;
using System;

public class TriggerEvent : MonoBehaviour 
{
    public event Action<TriggerEvent> Triggered;

    void OnTriggerEnter2D (Collider2D other)
    {
        var t = Triggered;
        if (t != null)
            Triggered (this);
        Debug.Log ("Triggered");
    }
}
