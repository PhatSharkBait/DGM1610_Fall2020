using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameAction pickUp;
    private Rigidbody rb;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void PickedUp(GameObject other)
    {
        pickUp.action.Invoke();
        var movePos = other.transform.position + new Vector3(0f, 0f, 2f);
        transform.position = movePos;
        transform.parent = other.transform;
        rb.velocity = Vector3.zero;
    }

    public void Kick()
    {
        rb.AddForce(15, 0, 15, ForceMode.Impulse);
        transform.parent = null;
    }
}
