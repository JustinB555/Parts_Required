using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    private Transform snowman;
    public ParticleSystem snow;

    private void Start()
    {
        snowman = gameObject.transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            Instantiate(snow, snowman.position, snowman.rotation);
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
