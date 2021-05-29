using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : CardCollection
{
    [SerializeField]    private GameHandler _gameHandler;
    [SerializeField]    private Hand _hand;
    [SerializeField]    private Card _cardPrefab;
    [SerializeField]    private DeckObject deckObject;
    [SerializeField]    private List<CardObject> cards;

    void Start()
    {
        _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        // cards = ShuffleCards(deckObject.cards);
        cards = deckObject.ShuffleCards();
    }

    void OnMouseDown()
    {
        if (_hand.CanDrawCard())
        {
            _hand.CreateNewCard(_cardPrefab, cards[0]);
            cards.Remove(cards[0]);
        }
    }
}
