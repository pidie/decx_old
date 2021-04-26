using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField]    private GameHandler _gameHandler;

    [Header("Data")]
    public int energyPoints;
    public int healthPoints;
    public int armorPoints;

    [SerializeField] private TMP_Text energyPointsDisplay;
    [SerializeField] private TMP_Text healthPointsDisplay;
    [SerializeField] private TMP_Text armorPointsDisplay;

    // add TextMesh energyPointDisplay etc etc

    private void Start() 
    {
        _gameHandler = GameObject.Find("GameHandler").GetComponent<GameHandler>();
        FetchData();
    }

    private void Update() 
    {
        energyPointsDisplay.text = energyPoints.ToString();
        healthPointsDisplay.text = healthPoints.ToString();
        armorPointsDisplay.text = armorPoints.ToString();
    }

    public void SpendEnergy(int energyCost)
    {
        this.energyPoints -= energyCost;
    }

    public bool CheckCanSpendEnergy(int energyCost)
    {
        if ( this.energyPoints < energyCost )
        {
            return false;
        }
        return true;
    }

    private void FetchData()
    {
        // this will eventually fetch the PlayerCreatureCardObject and set the values for this class.
        // for now, we'll hard code whatever statistics we need here.

        energyPoints = 4;
        healthPoints = 30;
        armorPoints  = 3;
    }
}
