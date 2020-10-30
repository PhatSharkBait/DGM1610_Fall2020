using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    private float moveSpeed = 10f;
    private float rotationSpeed = 2f;
    private Vector3 moveDir;
    private Quaternion rotation;

    private void Update()
    {
        //look in movement direction
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        Vector3 lookDir = new Vector3(horizontal, 0, vertical);
        
        if (Input.GetAxis("Vertical") !=0 || Input.GetAxis("Horizontal") !=0)
        {
            rotatePerson(lookDir);
            movePerson(lookDir);
        }

    }

    //rotate in toward given direction
    private void rotatePerson(Vector3 lookDir)
    {
        Vector3 newRotation = Vector3.RotateTowards(transform.forward, lookDir.normalized, rotationSpeed, 0.0f);
        transform.rotation = Quaternion.LookRotation(newRotation);
    }
    
    //move in facing direction
    private void movePerson(Vector3 moveDir)
    {
        //var xDir = Math.Cosh(transform.rotation.y);
        //Debug.Log(xDir);
        Vector3 movement = (moveDir * (Time.deltaTime * moveSpeed));
        transform.position += movement;
    }
}
