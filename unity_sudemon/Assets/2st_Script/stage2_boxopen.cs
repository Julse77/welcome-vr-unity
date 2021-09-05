using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_boxopen : MonoBehaviour
{
    private Animator anim;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Key")
        {
            //anim = this.paetong_in.GetComponent<Animator>();
            //anim.Play("1st_contPaetong");
            //키와 닿으면 상자열리는 애니메이션
        }

    }
}
