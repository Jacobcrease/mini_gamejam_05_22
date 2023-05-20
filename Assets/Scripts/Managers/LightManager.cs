using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public static LightManager instance;
    [SerializeField] private CandleController _candleController;
    [SerializeField] private float decreaseScaler = 10;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    private void FixedUpdate()
    {
        _candleController.SmallDecrease(Time.deltaTime * decreaseScaler);
    }

    public void RestoreCandle()
    {
        _candleController.FillUp();
    }
}
