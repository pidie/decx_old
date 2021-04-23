using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Round : MonoBehaviour 
{
    public int round = 0;
    public float timer;
    public TMP_Text timerCountdown;
    public bool isFirstPlayerTurn = true;
    private bool turnStarted = false;

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
            EndTurn();
        }
        else
        {
            if (!turnStarted)
            {
                StartTurn();
            }
        }
    }

    public void BeginNewRound()
    {
        if (isFirstPlayerTurn)
        {
            round += 1;
        }
    }

    public void NextTurn()
    {
        if (isFirstPlayerTurn)
        {
            isFirstPlayerTurn = false;
        }
        else
        {
            isFirstPlayerTurn = true;
            BeginNewRound();
        }
        timer = 25f;
    }

    public void StartTurn()
    {
        //calculate damage counters here
    }

    public void EndTurn()
    {
        //decrement buff duration
        NextTurn();
    }
}