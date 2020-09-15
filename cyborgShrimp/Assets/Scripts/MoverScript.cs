using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = speed*Input.GetAxis("Horizontal")*Time.deltaTime;
        var y = speed*Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(x, y, 0);   
    }
}
