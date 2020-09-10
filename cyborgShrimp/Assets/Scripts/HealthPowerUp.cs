using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int healthIncrease = 5;
    public void OnTriggerEnter(Collider other1)
    {
        Debug.Log("You got the health");
        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            playerHealth.currentHealth += healthIncrease;
        }
    }
}
