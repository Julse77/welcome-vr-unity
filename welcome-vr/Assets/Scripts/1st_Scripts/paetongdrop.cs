using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paetongdrop : MonoBehaviour
{
    // 고쳐볼 것
    private Animator anim;
    public GameObject paetong_in;
    public GameObject paetongAudio;
    public GameObject nailanim;
    private Animator anim2;
    public GameObject nail2;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Nail")
        {
            nail2.SetActive(false);
            nailanim.SetActive(true);
            anim2 = this.nailanim.GetComponent<Animator>();
            anim2.Play("1st_Nail");
            paetongAudio.SetActive(true);
            anim = this.paetong_in.GetComponent<Animator>();
            anim.Play("1st_contPaetong");
        }
   }


}
