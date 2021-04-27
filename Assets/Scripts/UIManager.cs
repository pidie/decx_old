using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour 
{
    [SerializeField]    private GameObject PlayerUI;
    [SerializeField]    private GameObject OpponentUI;

    [Header("Prefabs")]
    [SerializeField]    private GameObject CreatureUI;

    private void Start() 
    {
        
    }

    private void Update() 
    {
        
    }

    public void CreateNewCreatureUI(CreatureCardObject creature)
    {
        //Instantiate CreatureUI with creature data
    }

    public void DestroyCreatureUI(CardPosition position)
    {
        //Destroy the CreatureUI associated with position
    }

    /*

    This script will accept data from other scripts and use that data in 
    non-returning methods to keep the UI up to date. The methods will be 
    public.

    */
}