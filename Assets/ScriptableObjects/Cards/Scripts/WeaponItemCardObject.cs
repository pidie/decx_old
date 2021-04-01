using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Cards/Items/Weapon")]
public class WeaponItemCardObject : ItemCardObject
{
    public int damage = 1;
    public string damageType = "physical";  // will have to make a <T> type DamageType

    private void Awake() 
    {
        itemType = ItemType.Weapon;
    }
}