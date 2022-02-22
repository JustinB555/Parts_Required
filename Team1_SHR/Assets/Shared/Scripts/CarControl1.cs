using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl1 : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float steeringAngle;

    public WheelCollider FrontR, FrontL;
    public WheelCollider RearR, RearL;
    public float maxSteeringAngle = 10;
    public float mForce = 10;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
    }

    public void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal1");
        verticalInput = Input.GetAxis("Vertical1");
    }

    private void Steer()
    {
        steeringAngle = maxSteeringAngle * horizontalInput;
        FrontL.steerAngle = steeringAngle;
        FrontR.steerAngle = steeringAngle;
    }

    private void Accelerate()
    {
        RearL.motorTorque = verticalInput * mForce;
        RearR.motorTorque = verticalInput * mForce;
    }
}
