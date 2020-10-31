using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public List<Collectable> collectableList;

    private void Start()
    {
        
        for (var i = 0; i < collectableList.Count; i++)
        {
            var position = new Vector3(i*2, 0, 0);
            var item = collectableList[i];
            var newItem = new GameObject(item.name);
            newItem.transform.position = position;
            var sprite = newItem.AddComponent<SpriteRenderer>();
            sprite.sprite = item.art;
            //sprite.color = item.artColor;
        }
    }
}
