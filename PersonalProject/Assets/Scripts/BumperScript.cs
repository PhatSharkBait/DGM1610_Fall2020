using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    private float force = 5f;

    private void OnCollisionEnter(Collision other)
    {
        other.rigidbody.velocity = other.rigidbody.velocity * -force;
    }
}
