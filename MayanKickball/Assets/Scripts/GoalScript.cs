using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class GoalScript : MonoBehaviour {

    public FloatData score;
    public TextMeshProUGUI targetText;
    private ParticleSystem explosion;

    private void Start() {
        explosion = GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == 27) {
            other.gameObject.GetComponent<Ball>().Score();
            explosion.Play();
            AddPoint(1);
        }

        if (other.gameObject.layer == 8 || other.gameObject.layer == 16) {
            if (other.gameObject.GetComponent<BallHandler>().hasBall == true) {
                Transform Ball = other.transform.GetChild(other.transform.childCount - 1);
                Ball.gameObject.GetComponent<Ball>().Score();
            }
        }
    }

    private void AddPoint(float value) {
        score.UpdateValue(value);
        score.DisplayNumber(targetText);
    }
    
}
