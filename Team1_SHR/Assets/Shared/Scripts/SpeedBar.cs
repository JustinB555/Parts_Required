using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBar : MonoBehaviour
{
    public Slider speedS;
    public Gradient speedGradient;
    public Image speedFill;
    public float maxSpeed;

    public void Start()
    {
        SetMaxSpeed(maxSpeed);
    }

    public void SetMaxSpeed(float speed)
    {
        speedS.maxValue = speed;

        if (this.GetComponent<CarControl>())
        {
            CarControl cC = GetComponent<CarControl>();
            speedS.value = cC.mForce;
        }
        else if (this.GetComponent<CarControl1>())
        {
            CarControl1 cC = GetComponent<CarControl1>();
            speedS.value = cC.mForce;
        }
        else if (this.GetComponent<CarControl2>())
        {
            CarControl2 cC = GetComponent<CarControl2>();
            speedS.value = cC.mForce;
        }
        else if (this.GetComponent<CarControl3>())
        {
            CarControl3 cC = GetComponent<CarControl3>();
            speedS.value = cC.mForce;
        }

        speedFill.color = speedGradient.Evaluate(1f);
    }

    public void SetSpeed(float speed)
    {
        speedS.value += speed;

        speedFill.color = speedGradient.Evaluate(speedS.normalizedValue);
    }



}
