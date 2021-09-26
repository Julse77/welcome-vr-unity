using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_3roomTaegeukgi2 : MonoBehaviour
{
    private Animator anim;
    public GameObject Taegeukgi2;
    public GameObject Taegeukgi2_1;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Taegeukgi2")
        {
            Taegeukgi2_1.SetActive(true);
            Taegeukgi2.SetActive(false);
            anim = this.Taegeukgi2_1.GetComponent<Animator>();
            anim.Play("2st_Taegeukgi2");

        }

    }
}
