using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public MoverScript player;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("You got the speed");
        player.speed = 20;
    }
}
