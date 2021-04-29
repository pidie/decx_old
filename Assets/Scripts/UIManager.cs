using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour 
{
    [Header("Components")]
    [SerializeField]    private GameObject PlayerUI;
    [SerializeField]    private GameObject OpponentUI;
    [SerializeField]    private GameObject countdownTimer;
    [SerializeField]    private RectTransform canvas;

    [Header("Prefabs")]
    [SerializeField]    private GameObject CreatureUI;

    [Header("Creature UI")]
    [SerializeField]    private List<CreatureCardObject> CreatureList;
    [SerializeField]    private TMP_Text CreatureName;
    [SerializeField]    private TMP_Text CreatureHealth;

    [Header("Layout - Single Coordinates")]
    [SerializeField]    private float xPositionPlayer;
    [SerializeField]    private float xPositionOpponent;
    [SerializeField]    private float yStartPosition;

    [Header("Layout - Vector3")]
    [SerializeField]    private Vector3 countdownTimerPosition;

    private void Start() 
    {
        xPositionPlayer = 0f;
        yStartPosition = 0f;

        //x = height *.85 ; y = width * .5 ; z = 0 
        // countdownTimerPosition = new Vector3(canvas.rect.width * 0.5f, canvas.rect.height * 0.8f, 0);
        // countdownTimer.transform.position = countdownTimerPosition;
    }

    private void Update() 
    {
        
    }

    public void CreateNewCreatureUI(CreatureCardObject creature)
    {
        //this can be instantiated here, but updated by the individual managers

        CreatureList.Add(creature);
        int index = CreatureList.IndexOf(creature);
        GameObject NewCreatureUI = Instantiate(CreatureUI, new Vector3(xPositionPlayer, yStartPosition, 0f), Quaternion.identity);
        NewCreatureUI.transform.parent = GameObject.Find("UI/Canvas").transform;

        CreatureName = GameObject.Find("UI/Canvas/CreatureUI(Clone)/Canvas/Name").GetComponent<TMP_Text>();
        CreatureName.text = creature.title;
    }

    public void UpdateCreatureUI(CreatureCardObject creature)
    {
        
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