using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PowerUp : MonoBehaviour
{
    public TextMesh pointCounter;
    public int score;

    private void Awake()
    {
        score = 0;
        pointCounter.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        score += 10;
        pointCounter.text = "Score: " + score;
    }
}
