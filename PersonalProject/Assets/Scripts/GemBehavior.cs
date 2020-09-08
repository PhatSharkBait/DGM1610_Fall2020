using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other1)
    {
        Debug.Log("ouchie");
        Destroy(gameObject);
    }
}
