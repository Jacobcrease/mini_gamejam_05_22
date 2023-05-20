using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeKillScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collision");
        if(collider.CompareTag("Player"))
        {
            Debug.Log("Player Collision");


            GetComponent<AudioSource>().Play();

            StartCoroutine(KillPlayer());  // Let sound play then load scene
        }
    }
    IEnumerator KillPlayer ()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
