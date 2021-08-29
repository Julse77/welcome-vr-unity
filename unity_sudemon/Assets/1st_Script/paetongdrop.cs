using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paetongdrop : MonoBehaviour
{

    private Animator anim;
    public GameObject paetong_in;
    public GameObject paetongAudio;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Nail")
        {
            paetongAudio.SetActive(true);
            anim = this.paetong_in.GetComponent<Animator>();
            anim.Play("1st_contPaetong");
            
        }

    }
    
}
