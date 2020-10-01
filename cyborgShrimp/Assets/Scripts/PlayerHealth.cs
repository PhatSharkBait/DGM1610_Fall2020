using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        if (Input.GetButtonUp("Cancel"))
        {
            currentHealth--;
        }

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
