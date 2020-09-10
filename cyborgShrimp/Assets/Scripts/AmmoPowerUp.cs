using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    public PlayerScore playerScore;
    private void OnTriggerEnter(Collider other)
    {
        playerScore.ammo += 50;
        Debug.Log("You have " + playerScore.ammo + " ammo units");
    }
}
