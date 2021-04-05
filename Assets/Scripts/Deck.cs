using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using System.Linq;
using UnityEditor;

public class Deck : CardCollection
{
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private Hand _hand;
    [SerializeField]    private Card _cardPrefab;
    [SerializeField]    private DeckObject deckObject;
    [SerializeField]    private List<CardObject> cards;

    void Start()
    {
        cards = ShuffleCards(deckObject.cards);
    }

    void OnMouseDown()
    {
        if (_hand.DrawCard(cards[0]))
        {
            _hand.CreateNewCard(_cardPrefab, cards[0]);
            cards.Remove(cards[0]);
        }
    }

    public CardObject DrawCard()
    {
        return RemoveCardFromTop();
    }
}
