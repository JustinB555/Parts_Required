using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapHandle : MonoBehaviour
{
    public int CheckpointAmt;
    public int maxLaps;
    public bool lastLap = false;
    public GameObject winScreen;
    public Text winnerName;
    public string winner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CarLap>())
        {
            CarLap Car = other.GetComponent<CarLap>();
            Flipped Respawning = other.GetComponent<Flipped>();
            Respawning.fixRotation = Car.transform.localRotation;
            Respawning.lastPostion = Car.transform.localPosition;


            if (Car.CheckpointIndex == CheckpointAmt)
            {
                // car reached final checkpoint

                // reset the cars checkpoint index and finish the lap
                Car.CheckpointIndex = 0;
                Car.lapNumber++;

                Debug.Log(Car.lapNumber);


                if (Car.lapNumber == maxLaps && lastLap != true)
                    lastLap = true;
                else if (lastLap == true)
                {
                    Car.lapNumber = 3;
                    winner = Car.name;
                    winScreen.SetActive(true);
                    winnerName.text = (winner + " Won!");
                    Debug.Log("Won Race!");
                }
            }
        }
    }
}
