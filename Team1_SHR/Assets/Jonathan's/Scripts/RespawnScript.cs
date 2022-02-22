using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    [SerializeField] private Transform car;
    [SerializeField] private GameObject goCar;
    [SerializeField] private Transform car1;
    [SerializeField] private GameObject goCar1;
    [SerializeField] private Transform car2;
    [SerializeField] private GameObject goCar2;
    [SerializeField] private Transform car3;
    [SerializeField] private GameObject goCar3;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == goCar.name)
        {
            car.transform.position = respawnPoint.transform.position;
            car.transform.rotation = respawnPoint.transform.rotation;
        }

        if (other.gameObject.name == goCar1.name)
        {
            car1.transform.position = respawnPoint.transform.position;
            car1.transform.rotation = respawnPoint.transform.rotation;
        }

        if (other.gameObject.name == goCar2.name)
        {
            car2.transform.position = respawnPoint.transform.position;
            car2.transform.rotation = respawnPoint.transform.rotation;
        }

        if (other.gameObject.name == goCar3.name)
        {
            car3.transform.position = respawnPoint.transform.position;
            car3.transform.rotation = respawnPoint.transform.rotation;
        }
    }
}
