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
        LoadDeck();
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
            Debug.Log(cardData.name);
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
        string[] filteredFilesPaths = filesPaths.Where(filePath => {
            string fileExt = filePath.Substring(filePath.Length - 4);
            return fileExt == "json";
        }).ToArray();

        Card[] loadedCardData = filteredFilesPaths.Select(filePath => {
            string cardJson = _DataManager.GetJsonFromFile(filePath);
            CardModel cardModel = JsonUtility.FromJson<CardModel>(cardJson);
            //Card newCard = new Card();

            Card newCard = gameObject.AddComponent<Card>();

            newCard.LoadCard(cardModel);
            return newCard;
        }).ToArray();

        AddCardToTop(loadedCardData);
    }
}
