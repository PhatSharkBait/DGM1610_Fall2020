using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyUnityEvent : MonoBehaviour
{
    public UnityEvent myUnityEvent;

    private void OnTriggerEnter(Collider other)
    {
        myUnityEvent.Invoke();
    }
}
