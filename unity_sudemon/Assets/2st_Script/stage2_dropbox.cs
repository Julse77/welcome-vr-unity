using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_dropbox : MonoBehaviour
{
    public GameObject box;
    public GameObject ropesound2;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {
            ropesound2.SetActive(true);
            box.SetActive(true);
        }

    }
}
