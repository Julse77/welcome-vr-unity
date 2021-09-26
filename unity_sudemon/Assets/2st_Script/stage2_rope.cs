using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_rope : MonoBehaviour
{
    public GameObject nails;
    public GameObject ropesound;
    public GameObject nailsound;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {
            ropesound.SetActive(true);
            Invoke("dropnail", 1f);
            
        }
        
    }
    void dropnail()
    {
        nailsound.SetActive(true);
        nails.SetActive(true);
    }
}
