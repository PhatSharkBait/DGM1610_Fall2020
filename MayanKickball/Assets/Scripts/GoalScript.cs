using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == 27) {
            other.gameObject.GetComponent<Ball>().Score();
        }

        if (other.gameObject.layer == 8 || other.gameObject.layer == 16) {
            if (other.gameObject.GetComponent<BallHandler>().hasBall == true) {
                Transform Ball = other.transform.GetChild(other.transform.childCount - 1);
                Ball.gameObject.GetComponent<Ball>().Score();
            }
        }
    }
}
