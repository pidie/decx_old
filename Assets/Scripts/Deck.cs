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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Hand hand = _hand.GetComponent<Hand>();
        if (hand.getCardCount() < _maxCardsInHand)
        {
            //Card newCard = Instantiate(_card, _hand.transform);
            hand.addCardToHand();
        }
    }
}
