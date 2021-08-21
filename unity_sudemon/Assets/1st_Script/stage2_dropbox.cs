using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_dropbox : MonoBehaviour
{
    public GameObject box;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {

            box.SetActive(true);
        }

    }
}
