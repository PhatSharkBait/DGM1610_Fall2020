using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float spinSpeed;
    public GameObject propeller;

    private void Update()
    {
        propeller.transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}
