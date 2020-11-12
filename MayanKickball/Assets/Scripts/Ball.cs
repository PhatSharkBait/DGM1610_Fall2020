using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameAction newBall;
    public Rigidbody rb;
    private float force = 18f;
    private bool isPickedUp = false;
    

    public void PickedUp(GameObject other)
    {
        isPickedUp = true;
        transform.parent = other.transform;
        rb.isKinematic = true;
        other.GetComponent<BallHandler>().pickUp();
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

    private void OnCollisionEnter(Collision other)
    {
        if (!isPickedUp)
        {
            PickedUp(other.gameObject);
        }
        else
        {
            transform.parent = null;
            PickedUp(other.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        newBall.action.Invoke();
        Destroy(gameObject);
    }
}
