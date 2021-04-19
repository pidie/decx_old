using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour 
{
    public int round = 0;
    public float timer;
    public bool turnOne = true;     //controls which player gets to go
    public TMP_Text timerCountdown;

    public void BeginNewRound()
    {
        round += 1;
        timer = 25f;
    }

    public void NextTurn()
    {
        if ( turnOne )
        {
            turnOne = false;
        }
        else
        {
            turnOne = true;
            BeginNewRound();
        }
    }
}