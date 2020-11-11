using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DefensesSwitch : ScriptableObject
{
    public enum Defenses
    {
        Shield,
        Potions,
        ExtraHealth,
        Buffs,
        Dodging
    }

    public Defenses currentDefense;

    public void RunCurrentDefense()
    {
        switch (currentDefense)
        {
            case Defenses.Shield:
                break;
            case Defenses.Potions:
                break;
            case Defenses.ExtraHealth:
                break;
            case Defenses.Buffs:
                break;
            case Defenses.Dodging:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
