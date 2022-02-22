using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    ////////////////////////////////////////
    // Checklist
    ////////////////////////////////////////

    // 1) Have a max health amount.
    // 2) Have a current health amount.
    // 3) Have a default health amount.
    // 4) Us this code to change health.

    ////////////////////////////////////////
    // Fields
    ////////////////////////////////////////

    public float maxHealth = 100.0f;
    public float curHealth;
    // Have a default amount that starts lower then
    public float defHealth = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Set a base default health.
        curHealth = defHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
            PlayerDied(gameObject, this);
    }

    ////////////////////////////////////////
    // Methods
    ////////////////////////////////////////

    // The Method for taking damage. Needs the have the Health script attached.
    public void TakeDamage(float amount, Health itsHealth)
    {
        //itsHealth.curHealth = itsHealth.curHealth - amount;
        itsHealth.curHealth = itsHealth.curHealth - amount;
        #region// Debugging
        //DebuggingLog(itsHealth);
        #endregion
    }

    // The Method for Healing.
    public void RecoverDamage(float amount, Health itsHealth)
    {
        // We can do the same for healing.
        itsHealth.curHealth = itsHealth.curHealth + amount;
        if (itsHealth.curHealth > itsHealth.maxHealth)
            itsHealth.curHealth = itsHealth.maxHealth;
        #region// Debugging
        DebuggingLog(itsHealth);
        #endregion
    }

    public void PlayerDied(GameObject car, Health itsHealth)
    {
        Flipped Respawning = car.GetComponent<Flipped>();
        Respawning.Respawn();
        itsHealth.curHealth = itsHealth.defHealth;
    }

    ////////////////////////////////////////
    // Debugging
    ////////////////////////////////////////

    // For Debugging purposes only.
    void DebuggingLog(Health itsHealth)
    {
        Debug.Log(itsHealth.gameObject.name + "'s " + "current health = " + itsHealth.curHealth);
    }
}
