using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection_Simple : MonoBehaviour
{
    ////////////////////////////////////////
    // Checklist
    ////////////////////////////////////////

    // 1) I want to see if we hit something.
    // 2) I will determine which collider we hit.
    // 3) I will send the proper information to the correct collider.

    ////////////////////////////////////////
    // Fields
    ////////////////////////////////////////

    public Collider[] colliders;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ////////////////////////////////////////
    // Collision Events
    ////////////////////////////////////////

    // Start of the Code.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Check Trigger");
        for (int i = 0; i < colliders.Length; i++)
        {
            Debug.Log("Check Loop");
            if (colliders[i] == other)
            {
                colliders.Length.ToString();
                Debug.Log(colliders);
            }
        }
    }

}
