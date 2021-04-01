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
    [Range(1,12)]
    private int _maxCardsInHand;
    [SerializeField]
    private DataManager _DataManager;

    private Card _topCard;

    void Start()
    {
        _DataManager = new DataManager();
    }

    void OnMouseDown()
    {
        if (_hand.GetCardCount() < _maxCardsInHand)
        {
            Card drawnCard = DrawCard();
            _topCard = drawnCard;
            // CardModel cardData = drawnCard.GetCardData();
            drawnCard.name = drawnCard.cardData.title;
            // Debug.Log(drawnCard.cardData.title);
            _hand.AddCardToHand(drawnCard);
        }
        else
        {
            Debug.LogWarning("Hand is full.");
            return;
        }
    }

    public Card DrawCard()
    {
        return RemoveCardFromTop();
    }

    public void LoadDeck()
    {
        // todo: refactor to take deck identifier

        string currentPath = Directory.GetCurrentDirectory() + "\\CardLibrary";
        string[] filesPaths = Directory.GetFiles(currentPath);

        // filter for json files
        string[] filteredFilesPaths = filesPaths
            .Where(filePath => {
                string fileExt = filePath.Substring(filePath.Length - 4);
                return fileExt == "json";
            }).ToArray();

        Card[] loadedCardData = filteredFilesPaths
            .Select(filePath => {
                string cardJson = _DataManager.GetJsonFromFile(filePath);
                CardModel cardModel = JsonUtility.FromJson<CardModel>(cardJson);
                Card newCard = gameObject.AddComponent<Card>();
                newCard.LoadCard(cardModel);
                return newCard;
            }).ToArray();

        AddCardToTop(loadedCardData);
    }
}
