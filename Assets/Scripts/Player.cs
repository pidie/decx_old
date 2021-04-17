using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int energyPoints;       //add UI elements to display these stats
    public int healthPoints;
    public int armorPoints;

    // add TextMesh energyPointDisplay etc etc

    private void Start() 
    {
        FetchData();
        //set up energyPointDisplay etc etc to have the proper values
    }

    private void Update() 
    {
        // update the UI elements to reflect the values
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
