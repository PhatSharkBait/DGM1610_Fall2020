using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -8);

    private void Update()
    {
        //offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
