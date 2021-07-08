using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public GameObject room3Audio;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

            room3Audio.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        room3Audio.SetActive(false);
    }
}
