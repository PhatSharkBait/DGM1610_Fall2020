using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class WeaponsSwitch : ScriptableObject
{
    public enum Weapons
    {
        Sword,
        Pistol,
        Rifle,
        Ak,
        Grenade
    }

    public Weapons currentWeapons;
    
    public void RunCurrentWeapon()
    {
        switch (currentWeapons)
        {
            case Weapons.Sword:
                break;
            case Weapons.Pistol:
                break;
            case Weapons.Rifle:
                break;
            case Weapons.Ak:
                break;
            case Weapons.Grenade:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
