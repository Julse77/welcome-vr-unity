using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_doorOpen_2 : MonoBehaviour
{
    private Animator anim;
    public GameObject Object230;

    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Key")
        {
            anim = this.Object230.GetComponent<Animator>();
            anim.Play("2st_openbox");
            
        }

    }
}
