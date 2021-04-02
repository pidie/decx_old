using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Decks/Deck")]
public class DeckObject : ScriptableObject 
{
    [Header("Unity Data")]
    public GameObject prefab;

    [Header("Basic Information")]
    public string title;
    public string ID;
    [TextArea(5,10)]
    public string description;

    public Sprite image;

    public List<CardObject> cards;
}