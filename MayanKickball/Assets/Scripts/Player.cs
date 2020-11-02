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
    private float rotationSpeed = 50f;
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
        var lookAngle = Mathf.Rad2Deg*(Math.Asin(lookDir.x) + Math.Acos(lookDir.z));
        print(lookAngle);
        //var qTo = Quaternion.Euler(0, lookAngle, 0);
        //var lookSpeed = rotationSpeed * Time.deltaTime;
        //transform.rotation = Quaternion.Slerp(transform.rotation, qTo, lookSpeed);
    }
    
    //move in facing direction
    private void movePerson(Vector3 moveDir)
    {
        Vector3 movement = (moveDir * (Time.deltaTime * moveSpeed));
        transform.position += movement;
    }
}
