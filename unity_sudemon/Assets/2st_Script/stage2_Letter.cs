using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_Letter : MonoBehaviour
{
    public GameObject Key2;
    public GameObject Letter;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Letter")
        {

            Key2.SetActive(true);
            Letter.SetActive(false);
        }

    }
}
