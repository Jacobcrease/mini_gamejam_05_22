using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleRefill : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {

        Debug.Log("Collision");
        if(collider.CompareTag("Player"))
        {
            Debug.Log("Player Collision");


            LightManager.instance.RestoreCandle();
            GetComponent<AudioSource>().Play();

        }
    }
}
