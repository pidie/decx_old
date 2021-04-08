using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardCollection : MonoBehaviour
{
    private List<Card> _cardList = new List<Card>();
    private List<CardObject> _cardObjectList = new List<CardObject>();

    public int GetCardCount()
    {
        return _cardObjectList.Count;
    }
    public int GetCardCount(List<CardObject> cards)
    {
        return cards.Count();
    }

    protected void AddCardToTop(CardObject card)
    {
        _cardObjectList.Add(card);
    }

    protected void AddCardToTop(List<CardObject> cards)
    {
        _cardObjectList.AddRange(cards);
    }

    protected void AddCardToBottom(CardObject card)
    {
        _cardObjectList.Insert(0, card);
    }

    protected void AddCardToBottom(List<CardObject> cards)
    {
        _cardObjectList.InsertRange(0, cards);
    }

    protected CardObject RemoveCardFromTop()
    {
        if (_cardObjectList.Count == 0)
        {
            Debug.LogWarning("Deck is empty.");
            return null;
        }
        CardObject topCard =_cardObjectList.First();
        return _cardObjectList.Remove(topCard) ? topCard : null;
    }

    protected CardObject RemoveCardFromBottom()
    {
        if (_cardObjectList.Count == 0)
        {
            Debug.LogWarning("Deck is empty.");
            return null;
        }
        CardObject bottomCard = _cardObjectList.Last();
        return _cardObjectList.Remove(bottomCard) ? bottomCard : null;
    }

    protected void RemoveCard(CardObject card)
    {
        _cardObjectList.Remove(card);
    }

    protected void RemoveAllCards()
    {
        _cardObjectList.Clear();
    }

    protected void SwapCards(Card card1, Card card2)
    {
        int card1Index = _cardList.IndexOf(card1);
        int card2Index = _cardList.IndexOf(card2);
        _cardList[card1Index] = card2;
        _cardList[card2Index] = card1;
    }

    protected List<CardObject> ShuffleCards(List<CardObject> cards)
    {
        cards = cards.OrderBy(a => Guid.NewGuid()).ToList();
        return cards;
    }
}
