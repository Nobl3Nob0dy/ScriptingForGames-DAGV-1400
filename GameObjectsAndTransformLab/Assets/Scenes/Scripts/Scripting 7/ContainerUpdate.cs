using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerUpdate : MonoBehaviour
{
    public SimpleFloatData healthData;
    public SimpleFloatData manaData;
    public SimpleFloatData staminaData;

    public void ReduceHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }

    public void ReduceMana(float amount)
    {
        manaData.UpdateValue(amount);
    }

    public void ReduceStamina(float amount)
    {
        staminaData.UpdateValue(amount);
    }
}
