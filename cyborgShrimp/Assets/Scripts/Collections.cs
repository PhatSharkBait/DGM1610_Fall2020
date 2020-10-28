using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public List<GameObject> gameObjectList;

    private void Start()
    {
        foreach (var items in gameObjectList)
        {
            print(items);
        }
    }
}
