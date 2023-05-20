using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySenses : MonoBehaviour
{
    public bool isSeeing = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("I SEE YOU");
            isSeeing = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("I SEE YOU NOT");
            isSeeing = false;
        }
    }
}
