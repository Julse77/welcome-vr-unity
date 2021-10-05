using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_doorOpen_2 : MonoBehaviour
{
    private Animator anim;
    public GameObject Object230;
    public GameObject seconddoorsound;

    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Key2")
        {
            Object230.SetActive(false);
            seconddoorsound.SetActive(true);
            Invoke("sounddeactivate", 5f);
        }

    }
    void sounddeactivate()
    {
        seconddoorsound.SetActive(false);
    }
}
