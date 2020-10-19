using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float powerupStrength = 20f;
    public float speed = 15.0f;
    public GameObject cameraPivot;
    public bool hasPowerup;
    public GameObject powerupIndicator;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(cameraPivot.transform.forward * (speed * forwardInput));
        powerupIndicator.transform.position = transform.position + new Vector3(0f, -0.5f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>(); 
            Vector3 awayFromPlayer = (other.gameObject.transform.position - transform.position);
            
          Debug.Log("Player collided with " + other.gameObject + " with powerup set to " + hasPowerup);  
          enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(6);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}
