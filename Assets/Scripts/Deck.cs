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
    private Hand _hand;
    [SerializeField]
    private GameObject _card;
    [SerializeField]
    private int _maxCardsInHand;
    [SerializeField]
    private DataManager _DataManager;

    private Card _topCard;

    // Start is called before the first frame update
    void Start()
    {
        _DataManager = new DataManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (_hand.GetCardCount() < _maxCardsInHand)
        {
            HeldCard drawnCard = DrawCard();
            _topCard = drawnCard;
            CardModel cardData = drawnCard.GetCardData();
            drawnCard.name = cardData.title;
            Debug.Log(cardData.title);
            _hand.AddCardToHand(drawnCard);
        }
        else
        {
            ErrorHandIsFull();
        }
    }

    public HeldCard DrawCard()
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
