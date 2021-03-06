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
    public float moveSpeed = 680f;
    private float rotationSpeed = 10f;
    private Vector3 moveDir;
    private float rotateValue;
    public bool hasBall;
    private GameObject ballObj;
    private Rigidbody _rb;
    private float dashAmount = 7f;
    public bool isCooledDown = true;
    private float dashCooldownAmount = 2f;

    private void Start() {
        _rb = GetComponent<Rigidbody>();
    }

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

        if (hasBall == false && Input.GetButtonDown("Jump") && isCooledDown) {
            Dash();
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
        _rb.AddForce(movement);
    }

    private IEnumerator CoolDown(float time) {

       yield return new WaitForSeconds(time);
       isCooledDown = true;
    }

    private void Dash() {
        _rb.AddForce(gameObject.transform.forward*dashAmount, ForceMode.Impulse);
        isCooledDown = false;
        StartCoroutine(CoolDown(dashCooldownAmount));
    }
}


