using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int energyPoints;
    public int healthPoints;
    public int armorPoints;

    [SerializeField] private TMP_Text energyPointsDisplay;
    [SerializeField] private TMP_Text healthPointsDisplay;
    [SerializeField] private TMP_Text armorPointsDisplay;

    // add TextMesh energyPointDisplay etc etc

    private void Start() 
    {
        FetchData();
    }

    private void Update() 
    {
        energyPointsDisplay.text = energyPoints.ToString();
    }

    public bool SpendEnergy(int energyCost)
    {
        Debug.Log($"energyCost: {energyCost}");
        Debug.Log($"energyPoints: {energyPoints}");
        if ( this.energyPoints > energyCost)
        {
            Debug.LogWarning("Insufficient energy");
            return false;
        }
        else
        {
            this.energyPoints -= energyCost;
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
