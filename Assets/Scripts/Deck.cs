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
    [SerializeField]
    private GameHandler _gameHandler;
    [SerializeField]
    private Hand _hand;
    [SerializeField]
    private Card _cardPrefab;
    [SerializeField]
    private DataManager _DataManager;
    [SerializeField]
    private DeckObject deckObject;
    [SerializeField]
    private List<CardObject> cards;

    private Card _topCard;

    void Start()
    {
        // _DataManager = new DataManager();
        cards = ShuffleCards(deckObject.cards);
    }

    void OnMouseDown()
    {
        // if (_hand.GetCardCount() < _maxCardsInHand)
        // {
        //     Card drawnCard = DrawCard();
        //     _topCard = drawnCard;
        //     // CardModel cardData = drawnCard.GetCardData();
        //     drawnCard.name = drawnCard.cardData.title;
        //     // Debug.Log(drawnCard.cardData.title);
        //     _hand.AddCardToHand(drawnCard);
        // }
        // else
        // {
        //     Debug.LogWarning("Hand is full.");
        //     return;
        // }
        // _hand.AddCard();

        //transfer CardObject from deck to hand
        if (_hand.GetCardCount() < _hand.GetMaxCards())
        {
            if (_hand.DrawCard(cards[0]))
            {
                cards.Remove(cards[0]);
                _hand.CreateNewCard(_cardPrefab);
            }
        }
    }

    public CardObject DrawCard()
    {
        return RemoveCardFromTop();
    }

    // public void LoadDeck()
    // {
    //     // todo: refactor to take deck identifier

    //     string currentPath = Directory.GetCurrentDirectory() + "\\CardLibrary";
    //     string[] filesPaths = Directory.GetFiles(currentPath);

    //     // filter for json files
    //     string[] filteredFilesPaths = filesPaths
    //         .Where(filePath => {
    //             string fileExt = filePath.Substring(filePath.Length - 4);
    //             return fileExt == "json";
    //         }).ToArray();

    //     Card[] loadedCardData = filteredFilesPaths
    //         .Select(filePath => {
    //             string cardJson = _DataManager.GetJsonFromFile(filePath);
    //             CardModel cardModel = JsonUtility.FromJson<CardModel>(cardJson);
    //             Card newCard = gameObject.AddComponent<Card>();
    //             newCard.LoadCard(cardModel);
    //             return newCard;
    //         }).ToArray();

    //     AddCardToTop(loadedCardData);
    // }
}
