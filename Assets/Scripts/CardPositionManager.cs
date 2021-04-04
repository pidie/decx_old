using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPositionManager : MonoBehaviour
{
    [SerializeField]
    private Graveyard _graveyard;
    [SerializeField]
    private CardPosition _playerBackLeft;
    [SerializeField]
    private CardPosition _playerBackLeftCenter;
    [SerializeField]
    private CardPosition _playerBackCenter;
    [SerializeField]
    private CardPosition _playerBackRightCenter;
    [SerializeField]
    private CardPosition _playerBackRight;
    [SerializeField]
    private CardPosition _playerFrontLeft;
    [SerializeField]
    private CardPosition _playerFrontLeftCenter;
    [SerializeField]
    private CardPosition _playerFrontCenter;
    [SerializeField]
    private CardPosition _playerFrontRightCenter;
    [SerializeField]
    private CardPosition _playerFrontRight;
    [SerializeField]
    private CardPosition _opponentFrontLeft;
    [SerializeField]
    private CardPosition _opponentFrontLeftCenter;
    [SerializeField]
    private CardPosition _opponentFrontCenter;
    [SerializeField]
    private CardPosition _opponentFrontRightCenter;
    [SerializeField]
    private CardPosition _opponentFrontRight;
    [SerializeField]
    private CardPosition _opponentBackLeft;
    [SerializeField]
    private CardPosition _opponentBackLeftCenter;
    [SerializeField]
    private CardPosition _opponentBackCenter;
    [SerializeField]
    private CardPosition _opponentBackRightCenter;
    [SerializeField]
    private CardPosition _opponentBackRight;
    private List<CardPosition> positions;


    // Start is called before the first frame update
    void Start()
    {
        positions = new List<CardPosition>()    {_playerBackCenter, _playerBackLeft, _playerBackLeftCenter, _playerBackRight, _playerBackRight,
                                                _playerFrontCenter, _playerFrontLeft, _playerFrontLeftCenter, _playerFrontRight, _playerFrontRightCenter,
                                                _opponentBackCenter, _opponentBackLeft, _opponentBackLeftCenter, _opponentBackRight, _opponentBackRightCenter,
                                                _opponentFrontCenter, _opponentFrontLeft, _opponentFrontLeftCenter, _opponentFrontRight, _opponentFrontRightCenter};
    }

    // Update is called once per frame
    void Update()
    {
        foreach (CardPosition cardPosition in positions)
        {
            if ( cardPosition.IsBeingHovered() )
            {
                Debug.Log(cardPosition);
            }
        }
    }
}