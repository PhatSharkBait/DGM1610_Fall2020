using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject goodBall;

    private void Start()
    {
        
    }

    public void SpawnBall()
    {
        Instantiate(goodBall, goodBall.transform.position, goodBall.transform.rotation);
    }
}
