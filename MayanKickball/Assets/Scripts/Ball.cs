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
    private ParticleSystem explosion;

    private void Start() {
        Player playerScript = gameObject.GetComponent<Player>();
        explosion = gameObject.GetComponent<ParticleSystem>();
    }


    public void PickedUp(GameObject other)
    {
        if (other.gameObject.layer != 24) {
            isPickedUp = true;
            transform.parent = other.transform;
            rb.isKinematic = true;
            other.GetComponent<BallHandler>().pickUp();
        }
    }

    public void Kick()
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

    public void Score()
    {
        newBall.action.Invoke();
        isPickedUp = false;
        explosion.Play();
        Destroy(gameObject);
    }
}
