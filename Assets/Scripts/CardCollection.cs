﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardCollection: MonoBehaviour
{
    private List<Card> _cardList = new List<Card>();

    public int GetCardCount()
    {
        return _cardList.Count;
    }

    protected void AddCardToTop(Card card)
    {
        _cardList.Add(card);
    }

    protected void AddCardToTop(Card[] cards)
    {
        _cardList.AddRange(cards);
    }

    protected void AddCardToBottom(Card card)
    {
        _cardList.Insert(0, card);
    }

    protected void AddCardToBottom(Card[] cards)
    {
        _cardList.InsertRange(0, cards);
    }

    protected Card RemoveCardFromTop()
    {
        if (_cardList.Count == 0)
        {
            Debug.LogWarning("Deck is empty.");
            return null;
        }
        Card topCard =_cardList.First();
        return _cardList.Remove(topCard) ? topCard : null;
    }

    protected Card RemoveCardFromBottom()
    {
        if (_cardList.Count == 0)
        {
            Debug.LogWarning("Deck is empty.");
            return null;
        }
        Card bottomCard = _cardList.Last();
        return _cardList.Remove(bottomCard) ? bottomCard : null;
    }

    protected void RemoveCard(Card card)
    {
        _cardList.Remove(card);
    }

    protected void RemoveAllCards()
    {
        _cardList.Clear();
    }

    protected void SwapCards(Card card1, Card card2)
    {
        int card1Index = _cardList.IndexOf(card1);
        int card2Index = _cardList.IndexOf(card2);
        _cardList[card1Index] = card2;
        _cardList[card2Index] = card1;
    }

    protected void ShuffleCards(Card[] cards)
    {
        cards = cards.OrderBy(a => Guid.NewGuid()).ToArray();
    }
}
