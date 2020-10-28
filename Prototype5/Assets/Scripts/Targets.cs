﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Targets : MonoBehaviour
{
    public int pointValue;
    public ParticleSystem explosionParticle;
    
    private GameManager _gameManager;
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;

    void Start()
    {
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }
    
    private Vector3 RandomForce() { return Vector3.up * Random.Range(minSpeed, maxSpeed);}

    private float RandomTorque() { return Random.Range(-maxTorque, maxTorque);}
    
    private Vector3 RandomSpawnPos() { return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);}

    private void OnMouseDown()
    {
        _gameManager.UpdateScore(pointValue);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
