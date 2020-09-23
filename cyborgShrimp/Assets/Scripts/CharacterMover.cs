using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 500f;
    
    private Vector3 moveDirection;
    private float yDirection;

    void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput, gravity, 0);

        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded)
        {
            yDirection = -1;
        }
        
        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        
        controller.Move(moveDirection*Time.deltaTime);
    }
}
