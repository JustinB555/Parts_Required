using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipped : MonoBehaviour
{
    public Vector3 lastPostion;
    public Quaternion fixRotation;
    public GameObject thisPlayer;

    // Start is called before the first frame update
    void Start()
    {
        thisPlayer = this.gameObject;
        fixRotation = transform.localRotation;
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey(KeyCode.R) && thisPlayer.name == "Player 1")
            Respawn();
        if (Input.GetKey(KeyCode.Keypad0) && thisPlayer.name == "Player 2")
            Respawn();
        if (Input.GetKey(KeyCode.O) && thisPlayer.name == "Player 3")
            Respawn();
        if (Input.GetKey(KeyCode.M) && thisPlayer.name == "Player 4")
            Respawn();
    }

    public void Respawn()
    {
        transform.localPosition = lastPostion;
        transform.localRotation = fixRotation;
    }
}
