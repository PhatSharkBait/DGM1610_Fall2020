using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameAction pickUp;
    public Rigidbody rb;
    private float force = 18f;
    private bool isPickedUp = false;
    

    public void PickedUp(GameObject other)
    {
        isPickedUp = true;
        transform.parent = other.transform;
        rb.isKinematic = true;
        other.GetComponent<Player>().pickUp();
    }

    public void Kick(GameObject kicker)
    {
        if (isPickedUp)
        {
            rb.isKinematic = false;
            var forceKick = (force * transform.parent.forward);
            rb.AddForce(forceKick, ForceMode.Impulse);
            transform.parent = null;
            isPickedUp = false;
        }
    }
}
