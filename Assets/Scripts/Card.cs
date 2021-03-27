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
    public int ID;
    public string title;
    public string description;
}
