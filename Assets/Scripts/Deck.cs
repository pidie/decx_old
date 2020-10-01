using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Deck : CardCollection
{
    [SerializeField]
    private GameObject _hand;
    [SerializeField]
    private GameObject _card;
    [SerializeField]
    private int _maxCardsInHand;

    // Start is called before the first frame update
    void Start()
    {
        LoadDeck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Card DrawCard()
    {
        return RemoveCardFromTop();
    }

    private void OnMouseDown()
    {
        Hand hand = _hand.GetComponent<Hand>();
        if (hand.GetCardCount() < _maxCardsInHand)
        {
            //Card newCard = Instantiate(_card, _hand.transform);
            //hand.AddCardToHand();
        }
    }

    private void LoadDeck()
    {
        // fill deck with shuffled cards...
    }
}
