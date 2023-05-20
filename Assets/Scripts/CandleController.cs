using System;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class CandleController : MonoBehaviour
{
    [SerializeField] private Light light;
    [SerializeField] private float maxIntensity = 3.0f;
    [SerializeField] private float minIntensity = 0.0f;

    private float intensityDistance;

    private void Start()
    {
        intensityDistance = maxIntensity - minIntensity;
    }

    public float LightIntensity
    {
        get => light.intensity/intensityDistance;
        private set
        {
            float newVal = Math.Clamp(value, 0f, 1f);
            light.intensity = minIntensity + newVal*intensityDistance;
        }
    }
    
    public void SmallIncrease(float value)
    {
        LightIntensity += value;
    }
    
    public void SmallDecrease(float value)
    {
        LightIntensity -= value;
    }

    public void FillUp()
    {
        LightIntensity = 1;
    }
}
