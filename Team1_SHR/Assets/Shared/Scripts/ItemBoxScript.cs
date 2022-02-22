using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxScript : MonoBehaviour
{
    public float healAmount = 50.0f;
    public float speedInc = 100.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0 , 90 * Time.deltaTime , 0 );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            Health health = other.GetComponent<Health>();
            health.RecoverDamage(healAmount, health);

            SpeedBar sB = other.GetComponent<SpeedBar>();
            sB.SetSpeed(speedInc);

            if (other.GetComponent<CarControl>() != null)
            {
                CarControl cC = other.GetComponent<CarControl>();
                cC.mForce += speedInc;
                Debug.Log("mForce" + cC.mForce);
            }
            else if (other.GetComponent<CarControl1>())
            {
                CarControl1 cC = other.GetComponent<CarControl1>();
                cC.mForce += speedInc;
            }
            else if (other.GetComponent<CarControl2>())
            {
                CarControl2 cC = other.GetComponent<CarControl2>();
                cC.mForce += speedInc;
            }
            else if (other.GetComponent<CarControl3>())
            {
                CarControl3 cC = other.GetComponent<CarControl3>();
                cC.mForce += speedInc;
            }

            Destroy(gameObject);
            Debug.Log("It's Working!");
        }
    }





}
