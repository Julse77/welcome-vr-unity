using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_3roomTaegeukgi3 : MonoBehaviour
{
    private Animator anim;
    public GameObject Taegeukgi3;
    public GameObject Taegeukgi3_1;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Taegeukgi3")
        {
            Taegeukgi3_1.SetActive(true);
            Taegeukgi3.SetActive(false);
            anim = this.Taegeukgi3_1.GetComponent<Animator>();
            anim.Play("2st_Taegeukgi3");

        }

    }
}
