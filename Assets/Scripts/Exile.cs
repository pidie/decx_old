using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exile : MonoBehaviour
{
    [SerializeField]    private DeckObject deckObject;
    [SerializeField]    private List<CardObject> cards;
    
    void Start()
    {
        cards = deckObject.cards;
    }
}
