using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponTypes
{
    Axe,
    BastardSword,
    Battlehammer,
    BrassKnuckle,
    Crossbow,
    Dagger,
    DoubleCrossbow,
    Focus,
    Flail,
    Greataxe,
    HandCrossbow
    HuntingBow,
    Javelin,
    LongBow,
    Mace,
    Maul,
    Scythe,
    ShortBow,
    Spear,
    Staff,
    Sword,
    Wand,
    Warhammer,
    Whip,
    Zweihander
}

[CreateAssetMenu(fileName = "New Weapon", menuName = "Cards/Items/Weapon")]
public class WeaponItemCardObject : ItemCardObject
{
    public WeaponTypes weaponType;
    public int damage = 1;
    public string damageType = "physical";  // will have to make a <T> type DamageType

    private void Awake()
    {
        itemType = ItemType.Weapon;
        if (this.weaponType == Axe)
        {
            if (this.title == "Bearded Axe")
            {
                this.description.Add("\n\nThere is a 1d4 chance that this weapon will ignore Block from shields.");
            }
        }
    }
}