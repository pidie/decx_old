using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollection: MonoBehaviour
{
    protected List<Card> _cardList = new List<Card>();


    void Start()
    {

    }

    void Update()
    {

    }


    public void AddCardToTop(Card card)
    {
        _cardList.Add(card);
    }

    public void AddCardToTop(Card[] cards)
    {
        _cardList.AddRange(cards);
    }

    public void AddCardToBottom(Card card)
    {
        _cardList.Insert(0, card);
    }

    public void AddCardToBottom(Card[] cards)
    {
        _cardList.InsertRange(0, cards);
    }

    public void RemoveCardFromTop()
    {
        _cardList.RemoveAt(_cardList.Count);
    }

    public void RemoveCardFromBottom()
    {
        _cardList.RemoveAt(0);
    }

    public void RemoveCard(Card card)
    {
        _cardList.Remove(card);
    }

    public void SwapCards(Card card1, Card card2)
    {
        int card1Index = _cardList.IndexOf(card1);
        int card2Index = _cardList.IndexOf(card2);
        _cardList[card1Index] = card2;
        _cardList[card2Index] = card1;
    }

    public void ShuffleCards()
    {
        // todo...
    }

    public void ClearList()
    {
        _cardList.Clear();
    }
}
