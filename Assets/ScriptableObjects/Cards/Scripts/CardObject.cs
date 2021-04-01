using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The most primal version of a Card object.
/// <summary>
/// <remark>
/// There are three types of Card: Action, Creature, and Item.
/// <summary>
public enum CardType
{
    Action,
    Creature,
    Item
}
public abstract class CardObject : ScriptableObject 
{
    public GameObject prefab;
    public CardType cardType;

    public string title;
    public new string name;
    public string ID;
    [TextArea(15,20)]
    public string description;

    public Sprite image;

    public List<string> keywords;
}