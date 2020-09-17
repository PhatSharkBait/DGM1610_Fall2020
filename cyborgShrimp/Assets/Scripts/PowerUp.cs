﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PowerUp : MonoBehaviour
{
    public int value;
    public UnityEvent powerUpEvent;
    private void OnTriggerEnter(Collider other)
    {
        value += 10;
        powerUpEvent.Invoke();
    }
}
