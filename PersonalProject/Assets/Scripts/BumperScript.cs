using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    public float force = 20f;
    private Vector3 bounceDir;

    private void OnCollisionEnter(Collision other)
    {
        bounceDir = (transform.position - other.rigidbody.transform.position).normalized;
        
        //reverse object momentum
        var bumpVelocityX = bounceDir.x * -force;
        var bumpVelocityZ = bounceDir.y * -force;
  
        other.rigidbody.AddForce(bumpVelocityX, bounceDir.y, bumpVelocityZ, ForceMode.Impulse);
    }
}
