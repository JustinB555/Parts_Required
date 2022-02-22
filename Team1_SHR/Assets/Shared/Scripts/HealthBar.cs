using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider healthS;
    public Gradient healthGradient;
    public Image fill;

    // I fixed this one. I changed the parameter and made sure that it was grabbing the correct value.
    public void SetMaxHealth(Health health)
    {
        healthS.maxValue = health.maxHealth;
        healthS.value = health.curHealth;

        fill.color = healthGradient.Evaluate(1f);
    }

    // Same with this one too.
    public void SetHealth(Health health)
    {
        healthS.value = health.curHealth;

        fill.color = healthGradient.Evaluate(healthS.normalizedValue);
    }
}
