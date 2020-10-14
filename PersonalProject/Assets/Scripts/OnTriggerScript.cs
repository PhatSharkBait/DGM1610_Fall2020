using System;
using UnityEngine.Events;
using UnityEngine;

public class OnTriggerScript : MonoBehaviour
{
    public UnityEvent OnTriggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEvent.Invoke();
    }
}
