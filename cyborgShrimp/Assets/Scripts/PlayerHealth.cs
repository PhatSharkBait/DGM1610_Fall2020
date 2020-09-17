using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public TextMesh hitpointCounter;
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        if (Input.GetButtonUp("Submit"))
        {
            currentHealth--;
        }

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        hitpointCounter.text = currentHealth.ToString(CultureInfo.CurrentCulture) + "/" + maxHealth.ToString(CultureInfo.CurrentCulture);
    }
}
