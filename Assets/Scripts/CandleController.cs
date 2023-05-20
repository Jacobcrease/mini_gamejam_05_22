using System;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class CandleController : MonoBehaviour
{
    [SerializeField] private Light light;
    [SerializeField] private float maxIntensity = 3.0f;
    [SerializeField] private float minIntensity = 0.0f;
    [SerializeField] private float stepSize = 0.2f;

    public float LightIntensity
    {
        get => light.intensity;
        private set
        {
            if (value < minIntensity)
            {
                light.intensity = minIntensity;
            }
            if(value > maxIntensity)
            {
                light.intensity = maxIntensity;
            }
            if (value >= minIntensity && value <= maxIntensity)
            {
                light.intensity = value;
            }
        }
    }
    
    public void SmallIncrease()
    {
        LightIntensity += stepSize;
    }
    
    public void SmallDecrease()
    {
        LightIntensity -= stepSize;
    }

    public void FillUp()
    {
        LightIntensity = maxIntensity;
    }
}
