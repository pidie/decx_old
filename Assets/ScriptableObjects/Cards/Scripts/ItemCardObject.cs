using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Armor,
    Usable,
    Weapon
}
public abstract class ItemCardObject : CardObject 
{
    public ItemType itemType;

    [Range(0,5)]
    public int cooldownPeriodInTurns = 0;
    public int magicCost = 0;
    public int weight = 0;

    private void Awake() 
    {
        cardType = CardType.Item;
    }
}