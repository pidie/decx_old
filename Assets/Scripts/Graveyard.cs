﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graveyard : CardCollection
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToGraveyard(Card card)
    {
        AddCardToTop(card);
    }
}
