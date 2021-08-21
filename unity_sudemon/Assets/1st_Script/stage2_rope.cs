using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_rope : MonoBehaviour
{
    public GameObject nails;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {

            nails.SetActive(true);
        }

    }
}
