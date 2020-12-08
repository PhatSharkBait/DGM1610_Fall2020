using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachScript : MonoBehaviour {
    public List<Collectable> collectedObjects;

    public void Start() {
        foreach (var food in collectedObjects) {
            Debug.Log(food);
        }
    }
}
