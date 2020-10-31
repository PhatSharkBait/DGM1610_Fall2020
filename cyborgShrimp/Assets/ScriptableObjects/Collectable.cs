using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collectable : ScriptableObject
{
    public float powerLevel = 1f;
    public int cashValue = 10;
    public int hitPoints = 10;
    public int defense = 5;
    public int offense = 5;
    public Sprite art;
    public Color artColor = Color.blue;
}
