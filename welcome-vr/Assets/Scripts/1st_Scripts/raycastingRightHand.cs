using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastingRightHand : MonoBehaviour
{
    public GameObject RightH;
    public GameObject particle;
    public GameObject particle2;

    public GameObject paetongbutton;


    void Update()
    {
        reticle();
    }
    void reticle()
    {
        RaycastHit hit;
        Vector3 forward = RightH.transform.TransformDirection(Vector3.forward * 300);
        if(Physics.Raycast(RightH.transform.position,forward,out hit))
        {
            if(hit.transform.tag=="Padlock")
            {
                particle.SetActive(true);
                particle2.SetActive(true);
            }

            else if (hit.transform.tag == "paetong")
            {
                paetongbutton.SetActive(true);
            }
            else
            {
                particle.SetActive(false);
                particle2.SetActive(false);

                paetongbutton.SetActive(false);
            }
        }

        Debug.DrawRay(RightH.transform.position, forward, Color.blue);
    }
}
