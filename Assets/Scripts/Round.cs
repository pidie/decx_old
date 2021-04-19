using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Round : MonoBehaviour 
{
    public int round = 0;
    public float timer;
    public bool turnOne = true;     //controls which player gets to go
    public TMP_Text timerCountdown;

    private void Start() 
    {
        BeginNewRound();    
    }

    private void Update() 
    {
        timer -= Time.deltaTime;
        timerCountdown.text = Math.Ceiling(timer).ToString();
        
        if ( timer <= 0 )
        {
            NextTurn();
        }
    }

    public void BeginNewRound()
    {
        if (turnOne)
        {
            round += 1;
        }
    }

    public void NextTurn()
    {
        if (turnOne)
        {
            turnOne = false;
        }
        else
        {
            turnOne = true;
            BeginNewRound();
        }
        timer = 25f;
    }
}