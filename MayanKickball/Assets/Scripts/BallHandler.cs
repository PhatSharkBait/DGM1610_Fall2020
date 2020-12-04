using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public GameObject currentBall;
    public bool hasBall;
    private float ballDist = 1.35f;
    public GameObject manager;
    private SpawnManager _spawnManager;
    private Player playerScript;

    private void Start()
    {
        if (TryGetComponent(out playerScript)) {
        }
        
        _spawnManager = manager.gameObject.GetComponent<SpawnManager>();
        ChangeBall();
    }
    
    public void ChangeBall()
    {
        currentBall = _spawnManager.currentBall;
    }


    public void Update()
    {
        if (hasBall && Input.GetKeyDown(KeyCode.Space))
        {
            currentBall.GetComponent<Ball>().Kick();
            hasBall = false;
            if (playerScript != null) {
                playerScript.hasBall = false;
            }
        }
    }

    public void pickUp()
    {
        hasBall = true;
        if (playerScript != null) {
            playerScript.hasBall = true;
        }
        var playerTransform = new Vector3(transform.position.x, 0.5f, transform.position.z);
        var ballPos = playerTransform + (ballDist*transform.forward);
        currentBall.transform.position = ballPos;
    }
}
