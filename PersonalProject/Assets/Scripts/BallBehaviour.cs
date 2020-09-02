using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody ball;
    public float spinSpeed;
    private float zRotation = 0;
    private float xRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zRotation += Input.GetAxis("Horizontal") * spinSpeed * Time.deltaTime;
        xRotation += Input.GetAxis("Vertical") * spinSpeed * Time.deltaTime;
        ball.rotation  = Quaternion.Euler(xRotation, 0, zRotation);
        ball.velocity = new UnityEngine.Vector3(xRotation, 0, -zRotation);
    }
}
