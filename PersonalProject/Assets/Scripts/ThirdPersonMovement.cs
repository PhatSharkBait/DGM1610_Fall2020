using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    //I watched a video that showed me how to do this. I did my best to understand everything they did an why.
    private Vector3 moveDir;
    public Vector3 forceDir;
    public float speed;
    public float speedLimit;


    public CharacterController controller;
    public Transform cam;
    public Rigidbody playerPhysics;
    public Vector3 direction;

    private void Update()
    {
        //controlled with arrow keys or WASD
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        //movement direction from inputs
        direction = playerPhysics.velocity;
        direction.x = horizontal;
        direction.z = vertical;

        //if the ball is has velocity and player is holding the button
        if (direction.magnitude >= 0.1f && Input.GetAxis("Horizontal") != 0 || direction.magnitude >= 0.1f && Input.GetAxis("Vertical") != 0 )
        {
            //find angle between horizontal and vertical inputs, converted to degrees, adding rotation of the camera 
            var targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            
            //convert rotation to direction and move using the controller
            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            
            //controller.Move(moveDir.normalized * (speed * Time.deltaTime));
            
            forceDir = moveDir.normalized * (speed * Time.deltaTime);
            playerPhysics.AddForce(forceDir, ForceMode.Acceleration);
        }

        if (forceDir.x > speedLimit || forceDir.z > speedLimit)
        {
            playerPhysics.AddForce(-forceDir, ForceMode.Impulse);
        }

    }
}
