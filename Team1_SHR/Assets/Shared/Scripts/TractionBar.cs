using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TractionBar : MonoBehaviour
{
    public Slider tractionS;

    public void SetMaxTraction(float traction)
    {
        tractionS.maxValue = traction;
    }

    public void SetTraction(float traction)
    {
        tractionS.value = traction;
    }
}
