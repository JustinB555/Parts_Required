using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HitDetection_Mono : MonoBehaviour
{
    ////////////////////////////////////////
    // Checklist
    ////////////////////////////////////////

    // 1) This is the most simple version, only checking for a collision.
    // 2) Checks to see what hit us.
    // 3) If it is, how fast did it hit us?
    // 4) If it was fast enough, deal damage.
    // 5) Determine which health bar is ours and update it.

    ////////////////////////////////////////
    // Fields
    ////////////////////////////////////////

    #region// DEV ONLY, UI.text for development purposes.
    // I need something to reference to in order to talk with the text. (DEV ONLY)
    public Text devText1;
    public Text devText2;
    #endregion
    // We want to only pay attention to this GameObject's health.
    public Health ourHealth;
    // We need to determine the speed, so we need the Rigidbody.
    public Rigidbody ourRb;
    // Make the value for damage availble to change.
    public float impactNeeded = 50.0f;
    // Used to for the UI Health Bar.
    public HealthBar hB;

    public Transform Spawnpoint;

    public GameObject Prefab;

    public float Spawndelay;


    ////////////////////////////////////////
    // Tick Events
    ////////////////////////////////////////

    // Start is called before the first frame update
    void Start()
    {
        // Something to keep in mind: When assigning objects within the Inspector, you don't need this line of code. It will ruturn the item with null.
        //healthText = GetComponent<Text>();

        // Automatically assign the correct script.
        ourHealth = this.GetComponent<Health>();
        ourRb = this.GetComponent<Rigidbody>();
        hB = this.GetComponent<HealthBar>();

        // Used for UI.
        hB.SetMaxHealth(ourHealth);

    }

    // Update is called once per frame
    void Update()
    {
        #region// DEV ONLY, to display the vaules for Health and Speed.
        //devText1.text = (gameObject.name + " : " + ourHealth.curHealth.ToString());
        //devText1.text = ("Velocity = " + ourRb.velocity.magnitude.ToString());
        #endregion

        // Used for UI.
        hB.SetHealth(ourHealth);
    }

    ////////////////////////////////////////
    // Collision Events
    ////////////////////////////////////////

    // Code starts here.s
    private void OnCollisionEnter(Collision collision)
    {
        // I need to determine how had the objects collided. We are dividing because of Math, more specifically Physics.
        float impactForce = collision.impulse.magnitude / Time.time;
        
        // Check to see if we are hitting a car or not.
        if (collision.collider.tag == "Car")
        {
           
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation); 

            #region// DEV ONLY, to determine Velocity and Impact Force.
            //devText1.text = ("Velocity = " + ourRb.velocity.magnitude.ToString());
            //devText2.text = (gameObject.name + " Impact Force = " + impactForce);
            #endregion

            // Check to see how fast the car was moving.
            // May need to change, depending on what what is the common value.
            //             default: 50
            if (impactForce > impactNeeded)
            {
                // We are communicating with the Health script that controlls all the health.
                //               amount, itsHealth
                ourHealth.TakeDamage(10.0f, ourHealth);

                // For UI purposes.
                hB.SetHealth(ourHealth);
            }


            #region// Debugging
            //Debug.Log("The Car hit us!");
            //Debug.Log(collision.impulse.magnitude/Time.time);
            //Debug.Log(ourHealth.curHealth);
            #endregion
        }
    }
}
