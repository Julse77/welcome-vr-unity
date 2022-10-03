using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockSoundFunction : MonoBehaviour
{
    public GameObject room3Audio;
    public GameObject dust;
    public GameObject dust2;
    public GameObject dust3;
    public GameObject dust4;
    public GameObject dust5;
    public GameObject dust6;
    public GameObject dust7;
    public GameObject dust8;
    public GameObject dust9;
    public GameObject dust10;
    public GameObject dust11;
    public GameObject dust12;
    public GameObject dust13;
    public GameObject dust14;
    public GameObject dust15;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

            room3Audio.SetActive(true);
            CreateDust();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        room3Audio.SetActive(false);
        dust.SetActive(false);
        dust2.SetActive(false);
        dust3.SetActive(false);
        dust4.SetActive(false);
        dust5.SetActive(false);
        dust6.SetActive(false);
        dust7.SetActive(false);
        dust8.SetActive(false);
        dust9.SetActive(false);
        dust10.SetActive(false);
        dust11.SetActive(false);
        dust12.SetActive(false);
        dust13.SetActive(false);
        dust14.SetActive(false);
        dust15.SetActive(false);
    }

    private void CreateDust()
    {
        dust.SetActive(true);
        dust2.SetActive(true);
        dust3.SetActive(true);
        dust4.SetActive(true);
        dust5.SetActive(true);
        dust6.SetActive(true);
        dust7.SetActive(true);
        dust8.SetActive(true);
        dust9.SetActive(true);
        dust10.SetActive(true);
        dust11.SetActive(true);
        dust12.SetActive(true);
        dust13.SetActive(true);
        dust14.SetActive(true);
        dust15.SetActive(true);
    }
    
}
