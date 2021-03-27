<<<<<<< HEAD
﻿using System;
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
            Card drawnCard = DrawCard();
            _topCard = drawnCard;
            CardModel cardData = drawnCard.GetCardData();
            Debug.Log(cardData.title);
            _hand.AddCardToHand(drawnCard);
        }
        else
        {
            ErrorHandIsFull();
        }

        // return true;
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
=======
﻿using System;
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
    private GameObject _hand;
    [SerializeField]
    private GameObject _card;
    [SerializeField]
    private int _maxCardsInHand;
    [SerializeField]
    private DataManager _DataManager;

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
        Card drawnCard = DrawCard();
        if (drawnCard)
        {
            CardModel cardData = drawnCard.GetCardData();
            Debug.Log(cardData.title);
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
>>>>>>> 7c186a7cb6f73a835e20c975e4bd6fb43eea3da4
