using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    //I watched a video that showed me how to do this. I did my best to understand everything they did an why.
    public CharacterController controller;
    public Transform cam;
    public Rigidbody playerPhysics;
    
    public float speed = 100f;

    void Update()
    {
        //controlled with arrow keys or WASD
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        //movement direction from inputs
        Vector3 direction = playerPhysics.velocity;
        direction.x = horizontal;
        direction.z = vertical;
        
        
        if (direction.magnitude >= 0.1f && Input.GetAxis("Horizontal") != 0 || direction.magnitude >= 0.1f && Input.GetAxis("Vertical") != 0 )
        {
            //find angle between horizontal and vertical inputs, converted to degrees, adding rotation of the camera 
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            
            //convert rotation to direction and move using the controller
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            //controller.Move(moveDir.normalized * (speed * Time.deltaTime));
            
            playerPhysics.AddForce(moveDir.normalized * (speed * Time.deltaTime));

        }

    }
}
