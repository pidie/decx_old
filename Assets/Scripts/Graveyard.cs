using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graveyard : CardCollection
{
    [SerializeField]
    private DeckObject deckObject;
    [SerializeField]
    private List<CardObject> cards;

    // Start is called before the first frame update
    void Start()
    {
        cards = deckObject.cards;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToGraveyard(CardObject card)
    {
        AddCardToTop(card);
    }
}