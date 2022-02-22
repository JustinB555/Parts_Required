using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempLapCheckPoint : MonoBehaviour
{
    public int Index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CarLap>())
        {
            CarLap Car = other.GetComponent<CarLap>();

            if (Car.CheckpointIndex == Index + 1 || Car.CheckpointIndex == Index - 1)
                // if the car last checkpoint was either before or after this checkpoint, set the car current
            {
                Car.CheckpointIndex = Index;
                Flipped Respawning = other.GetComponent<Flipped>();
                Respawning.fixRotation = Car.transform.localRotation;
                Respawning.lastPostion = Car.transform.localPosition;
                Debug.Log(Index);
            }

        }
    }
}
