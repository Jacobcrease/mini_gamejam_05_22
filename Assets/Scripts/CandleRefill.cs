using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleRefill : MonoBehaviour
{
    bool used = false;
    private void OnTriggerEnter(Collider collider)
    {
        if(!used)
        {
            used = true;
            Debug.Log("Collision");
            if(collider.CompareTag("Player"))
            {
                Debug.Log("Player Collision");


                LightManager.instance.RestoreCandle();
                GetComponent<AudioSource>().Play();
                StartCoroutine(DestroySelf());
            }
        }
    }
    IEnumerator DestroySelf ()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
        

    }
}
