using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLap : MonoBehaviour
{
    public int lapNumber; //The lap the player is on
    public int CheckpointIndex; //what current checkpoint player is on

    private void Start()
    {
        lapNumber = 1;
        CheckpointIndex = 0;
    }
}
