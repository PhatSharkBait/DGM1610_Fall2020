using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEvent : MonoBehaviour
{
    public UnityEvent collisionEvent;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer != 28) {collisionEvent.Invoke();}
    }
}
