using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_dropbox : MonoBehaviour
{
    public GameObject boxup;
    public GameObject boxdown;
    public GameObject ropesound2;
    public GameObject dropboxsound;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {
            ropesound2.SetActive(true);
            boxup.SetActive(true);
            boxdown.SetActive(true);
            dropboxsound.SetActive(true);
        }

    }
}
