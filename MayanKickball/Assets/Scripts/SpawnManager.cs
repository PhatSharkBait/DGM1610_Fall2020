using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject goodBall;
    public GameObject currentBall;
    public GameAction changeBall;

    public void SpawnBall()
    {
        var newBall = Instantiate(goodBall, goodBall.transform.position, goodBall.transform.rotation);
        currentBall = newBall;
        changeBall.action.Invoke();
    }
}
