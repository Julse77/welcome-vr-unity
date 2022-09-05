using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_3room : MonoBehaviour
{
    private Animator anim;
    public GameObject Taegeukgi1;
    public GameObject Taegeukgi1_1;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Taegeukgi1")
        {
            Taegeukgi1_1.SetActive(true);
            Taegeukgi1.SetActive(false);
            anim = this.Taegeukgi1_1.GetComponent<Animator>();
            anim.Play("2st_Taegeukgi1");

        }

    }
}
