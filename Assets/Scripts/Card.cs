using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private string _name;
    private int _id;
    private string _title;
    private string _description;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public CardModel GetCardData()
    {
        return new CardModel() {
            name = _name,
            ID = _id,
            title = _title,
            description = _description
        };
    }

    public void LoadCard(CardModel inputData)
    {
        _name = inputData.name;
        _id = inputData.ID;
        _title = inputData.title;
        _description = inputData.description;
    }
}

[Serializable]
public class CardModel
{
    public string name;
    public int ID;
    public string title;
    public string description;
}