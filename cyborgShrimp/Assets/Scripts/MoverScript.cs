using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        var x = speed*Input.GetAxis("Horizontal")*Time.deltaTime;
        var y = speed*Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(x, y, 0);   
    }
}
