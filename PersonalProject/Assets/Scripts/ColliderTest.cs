using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    public Collider playerCollider;

    private void Awake()
    {
        playerCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject);
    }
}
