using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public GameObject currentBall;
    public bool hasBall;
    private float ballDist = 1.35f;


    private void Start()
    {
        Action<GameObject> changeBall = ChangeBall;
    }


    public void Update()
    {
        if (hasBall && Input.GetKeyDown(KeyCode.Space))
        {
            currentBall.GetComponent<Ball>().Kick(gameObject);
            hasBall = false;
        }
    }

    public void pickUp()
    {
        hasBall = true;
        currentBall = transform.GetChild(2).gameObject;
        var playerTransform = new Vector3(transform.position.x, 0.5f, transform.position.z);
        var ballPos = playerTransform + (ballDist*transform.forward);
        currentBall.transform.position = ballPos;
    }

    public void ChangeBall(GameObject newBall)
    {
        currentBall = newBall;
    }
}
