using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemySenses senses;
    private bool currentlyChasing = false;

    private void FixedUpdate()
    {
        if (senses.isSeeing && !currentlyChasing)
        {
            startChasing();
        }

        if (!senses.isSeeing && currentlyChasing)
        {
            stopChasing();
        }
    }

    private void stopChasing()
    {
        throw new NotImplementedException();
    }

    private void startChasing()
    {
        throw new NotImplementedException();
    }
}
