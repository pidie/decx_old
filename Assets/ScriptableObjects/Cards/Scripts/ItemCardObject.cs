using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Armor,
    Usable,
    Weapon
}
public enum ArmorTypes
{
    Belt,
    Boots,
    Bracers,
    Cape,
    Chestplate,
    Gauntlets,
    Helm,
    Pauldrons
}
public abstract class ItemCardObject : CardObject 
{
    public ItemType itemType;

    [Range(0,5)]
    public int cooldownPeriodInTurns = 0;
    public int magicRequired = 0;
    public int weight = 0;
    [Range(1,4)]
    public int range = 1;

    private void Awake() 
    {
        cardType = CardType.Item;
    }
}