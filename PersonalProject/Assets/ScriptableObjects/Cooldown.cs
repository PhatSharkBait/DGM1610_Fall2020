using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Cooldown : ScriptableObject
{
    IEnumerator NewCooldown(float value)
    {
        yield return new WaitForSeconds(value);
    }
}
