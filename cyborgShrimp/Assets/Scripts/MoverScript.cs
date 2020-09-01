using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 3f;
    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World?");
    }

    // Update is called once per frame
    void Update()
    {
        x = speed*Input.GetAxis("Horizontal")*Time.deltaTime;
        y = speed*Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(x, y, z);   
    }
}
