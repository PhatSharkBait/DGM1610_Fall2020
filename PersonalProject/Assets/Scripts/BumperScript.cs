using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    public float force = 15f;
    private Vector3 playerMomentum;

    private void OnCollisionEnter(Collision other)
    {
        playerMomentum = other.rigidbody.velocity;
        
        //reverse object momentum
        var bumpVelocityX = playerMomentum.normalized.x * -force;
        var bumpVelocityZ = playerMomentum.normalized.z * -force;
  
        other.rigidbody.AddForce(bumpVelocityX, playerMomentum.y, bumpVelocityZ, ForceMode.Impulse);
        Debug.Log(other.rigidbody.velocity);
    }
}
