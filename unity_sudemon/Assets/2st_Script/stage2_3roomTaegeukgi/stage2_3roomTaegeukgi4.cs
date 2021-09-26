using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_3roomTaegeukgi4 : MonoBehaviour
{
    private Animator anim;
    public GameObject Taegeukgi4;
    public GameObject Taegeukgi4_1;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Taegeukgi4")
        {
            Taegeukgi4_1.SetActive(true);
            Taegeukgi4.SetActive(false);
            anim = this.Taegeukgi4_1.GetComponent<Animator>();
            anim.Play("2st_Taegeukgi4");

        }

    }
}
