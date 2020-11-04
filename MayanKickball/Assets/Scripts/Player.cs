﻿using System;
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
    private float rotationSpeed = 10f;
    private Vector3 moveDir;
    private Quaternion rotation;
    private float rotateValue;
    private bool hasBall;
    public GameAction kick;

    private void Update()
    {
        //look in movement direction
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        var lookDir = new Vector3(horizontal, 0, vertical);
        
        if (Input.GetAxis("Vertical") !=0 || Input.GetAxis("Horizontal") !=0)
        {
            rotatePerson(lookDir);
            movePerson(lookDir);
        }

        if (hasBall && Input.GetKeyDown(KeyCode.Space))
        {
            kick.action.Invoke();
            hasBall = false;
        }
    }

    //rotate toward given direction
    private void rotatePerson(Vector3 lookDir)
    {
        rotateValue = (float)(Mathf.Rad2Deg * (Math.Atan2(lookDir.x, lookDir.z)));
        var rotateTo = Quaternion.Euler(0, rotateValue, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotateTo, rotationSpeed * Time.deltaTime);
    }
    
    //move in facing direction
    private void movePerson(Vector3 moveDir)
    {
        Vector3 movement = (moveDir * (Time.deltaTime * moveSpeed));
        transform.position += movement;
    }

    public void pickUp()
    {
        hasBall = true;
    }
}


