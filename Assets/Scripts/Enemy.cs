using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemySenses senses;
    [SerializeField] private float enemySpeed = 5f;
    private bool currentlyChasing = false;
    private Vector3 startPosition;
    private Quaternion startRotation;

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

    private void Start()
    {
        startPosition = transform.position;
        startRotation = new Quaternion();
    }

    private void Update()
    {
        if (currentlyChasing)
        {
            var targetPos = senses.target.position;
            transform.LookAt(targetPos);
        }
    }

    private void stopChasing()
    {
        currentlyChasing = false;
        transform.position = startPosition;
    }

    private void startChasing()
    {
        Debug.Log("BEGIN CHASE");
        currentlyChasing = true;
    }
}
