using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    [SerializeField] GameObject canvasToShow;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collision");
        if(collider.CompareTag("Player"))
        {
            Debug.Log("Player Collision");
            canvasToShow.SetActive(true);

            GetComponent<AudioSource>().Play();
        }
    }
   // void OnTriggerEnter ()
}
