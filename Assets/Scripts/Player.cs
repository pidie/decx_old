using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int energyPoints;       //add UI elements to display these stats
    public int healthPoints;
    public int armorPoints;

    [SerializeField] private TMP_Text energyPointsDisplay;

    // add TextMesh energyPointDisplay etc etc

    private void Start() 
    {
        FetchData();
        //set up energyPointDisplay etc etc to have the proper values
    }

    private void Update() 
    {
        energyPointsDisplay.text = energyPoints.ToString();
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
