﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Time;
// using Vector3 = System.Numerics.Vector3;

public class Jump : MonoBehaviour
{
    public float jumpVelocity = 300f;
    public float fallMultiplier = 2.5f;
    public float shortJumpMultiplier = 2f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0, jumpVelocity, 0);
        }
        
        
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * (Physics.gravity.y * (fallMultiplier - 1) * deltaTime);
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * (Physics.gravity.y * (shortJumpMultiplier - 1) * deltaTime);
        }
    }
}