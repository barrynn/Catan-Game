using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettlementValues : MonoBehaviour
{

    private int occupied;
    private int occupier;
    private int leftRoadOccupied;
    private int rightRoadOccupied;
    private int leftRoadOccupier;
    private int rightRoadOccupier;
    public GameObject leftRoad;
    public GameObject rightRoad;
    private int upRoadOccupied;
    private int downRoadOccupied;
    private int upRoadOccupier;
    private int downRoadOccupier;
    public GameObject upRoad;
    public GameObject downRoad;
    public GameObject[] neighbors;

    //sets basic values
    void Start()
    {
        occupied = 0;
        occupier = -1;
        leftRoadOccupied = 0;
        leftRoadOccupier = -1;
        rightRoadOccupied = 0;
        rightRoadOccupier = -1;
        upRoadOccupied = 0;
        upRoadOccupier = -1;
        downRoadOccupied = 0;
        downRoadOccupier = -1;

    }

    public void setOccupier(int playerNum)
    {
        occupied = 1;
        occupier = playerNum;
    }
    public void setLeftRoadOccupier(int playerNum)
    {
        leftRoadOccupied = 1;
        leftRoadOccupier = playerNum;
    }
    public void setRightRoadOccupier(int playerNum)
    {
        rightRoadOccupied = 1;
        rightRoadOccupier = playerNum;
    }
    public void setUpRoadOccupier(int playerNum)
    {
        upRoadOccupied = 1;
        upRoadOccupier = playerNum;
    }
    public void setDownRoadOccupier(int playerNum)
    {
        downRoadOccupied = 1;
        downRoadOccupier = playerNum;
    }
    public void setNeighbors(GameObject[] neighborsList)
    {
        neighbors = neighborsList;
    }
}
