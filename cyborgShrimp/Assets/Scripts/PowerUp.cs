using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PowerUp : MonoBehaviour
{
    public UnityEvent powerUpEvent;
    private void OnTriggerEnter(Collider other)
    {
        powerUpEvent.Invoke();
    }
}
