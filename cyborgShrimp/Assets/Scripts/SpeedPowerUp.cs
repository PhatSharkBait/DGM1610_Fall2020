using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public MoverScript player;

    public void OnTriggerEnter(Collider other)
    {
        player.speed = 20;
    }
}
