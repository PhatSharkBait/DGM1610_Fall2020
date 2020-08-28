using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody ball;
    public float spinSpeed;
    private float yRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yRotation+= spinSpeed;
        ball.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
