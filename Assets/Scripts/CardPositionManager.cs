using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPositionManager : MonoBehaviour
{
    [SerializeField]    private Graveyard _graveyard;

    [SerializeField]    private CardPosition _playerBackLeft;
    [SerializeField]    private CardPosition _playerBackLeftCenter;
    [SerializeField]    private CardPosition _playerBackCenter;
    [SerializeField]    private CardPosition _playerBackRightCenter;
    [SerializeField]    private CardPosition _playerBackRight;

    [SerializeField]    private CardPosition _playerFrontLeft;
    [SerializeField]    private CardPosition _playerFrontLeftCenter;
    [SerializeField]    private CardPosition _playerFrontCenter;
    [SerializeField]    private CardPosition _playerFrontRightCenter;
    [SerializeField]    private CardPosition _playerFrontRight;

    [SerializeField]    private CardPosition _opponentFrontLeft;
    [SerializeField]    private CardPosition _opponentFrontLeftCenter;
    [SerializeField]    private CardPosition _opponentFrontCenter;
    [SerializeField]    private CardPosition _opponentFrontRightCenter;
    [SerializeField]    private CardPosition _opponentFrontRight;

    [SerializeField]    private CardPosition _opponentBackLeft;
    [SerializeField]    private CardPosition _opponentBackLeftCenter;
    [SerializeField]    private CardPosition _opponentBackCenter;
    [SerializeField]    private CardPosition _opponentBackRightCenter;
    [SerializeField]    private CardPosition _opponentBackRight;

    [Header("Lists")]
    [SerializeField]    private List<CardPosition> positions;
    [SerializeField]    private List<CardPosition> playerPositions;
    [SerializeField]    private List<CardPosition> opponentPositions;


    // Start is called before the first frame update
    void Start()
    {
        playerPositions = new List<CardPosition>()  {_playerBackLeft, _playerBackLeftCenter, _playerBackCenter, _playerBackRight, _playerBackRight,
                                                    _playerFrontLeft, _playerFrontLeftCenter, _playerFrontCenter, _playerFrontRight, _playerFrontRightCenter};
        opponentPositions = new List<CardPosition>(){_opponentBackLeft, _opponentBackLeftCenter, _opponentBackCenter, _opponentBackRight, _opponentBackRightCenter,
                                                    _opponentFrontLeft, _opponentFrontLeftCenter, _opponentFrontCenter, _opponentFrontRight, _opponentFrontRightCenter};
        positions = new List<CardPosition>();
        positions.AddRange(playerPositions);
        positions.AddRange(opponentPositions);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (CardPosition cardPosition in positions)
        {
            if ( cardPosition.GetIsOccupied() )
            {
                
            }
        }
    }
}