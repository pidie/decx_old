using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    private GameHandler _gameHandler;
    [SerializeField]
    private Hand _hand;
    
    private string _name;
    private string _id;
    private string _title;
    private string _description;

    public CardObject cardObject;
    
    public CardModel cardData;

    protected bool CardIsInHand()
    {
        if (transform.parent == _hand)
        {
            return true;
        }
        return false;
    }

    void Start()
    {
        cardData = GetCardData();
    }

    private void OnMouseDown() 
    {
        
    }

    private void OnMouseUpAsButton()
    {
        if (CardIsInHand())
        {
            if (Input.GetMouseButton(0))
            {
                /*
                if card.type == creature:
                    for each available cardPosition:
                        cardPosition.highlight();
                else if card.type == action:
                    if card.action.target == null:
                        gameboard.center.highlight
                    else:
                        for each available target:
                            target.highlightAttack();
                else if card.type == item:
                    confirm item usage
                */
            }
            else if (Input.GetMouseButton(1))
            {
                /*
                show information on the card
                */
            }
            else if (Input.GetMouseButton(2))
            {
                /*
                3d viewer for card
                */
            }
        }
    }

    // private void OnMouseDrag() 
    // {
    //     if (CardIsInHand())
    //     {
    //         if (Input.GetMouseButton(0))
    //         {
    //             transform.position = transform.position + Input.mousePosition;
    //         }
    //     }
    // }

    public CardModel GetCardData()
    {
        return new CardModel() 
        {
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

    public void AddText(Vector3 position)
    {
        GameObject text = new GameObject();
        TextMesh textMesh = text.AddComponent<TextMesh>();
        textMesh.text = _title;
        textMesh.fontSize = 5 + 5;
        textMesh.color = Color.black;
        Debug.Log(textMesh.transform.position);
        textMesh.transform.position = position;
    }

    public void AddText(float posX, float posY, float posZ)
    {   //overloaded version
        Vector3 position = new Vector3(posX, posY, posZ);
        AddText(position);
    }

    public void AddText()
    {   //overload - no position argument given
        AddText(0, 0, 0);
    }
}

[Serializable]
public class CardModel
{
    public string name;
    public string ID;
    public string title;
    public string description;
}
