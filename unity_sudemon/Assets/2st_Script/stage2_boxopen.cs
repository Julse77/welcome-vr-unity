using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_boxopen : MonoBehaviour
{
    private Animator anim;
    public GameObject Object231;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Key")
        {
            anim = this.Object231.GetComponent<Animator>();
            anim.Play("2st_openbox");
            
        }

    }
}
