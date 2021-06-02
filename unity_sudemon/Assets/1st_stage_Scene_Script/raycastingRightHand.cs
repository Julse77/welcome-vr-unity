using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastingRightHand : MonoBehaviour
{
    public GameObject RightH;
    public GameObject particle;
    public GameObject particle2;
    public GameObject firstroomParticle;
    public GameObject doorframeParticle;
    public GameObject doorframeParticle2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
            else if(hit.transform.tag=="Q1")
            {
                firstroomParticle.SetActive(true);
            }
            else if (hit.transform.tag == "doorframe2")
            {
                doorframeParticle.SetActive(true);
            }
            else if (hit.transform.tag == "doorframe3")
            {
                doorframeParticle2.SetActive(true);
            }
            else
            {
                particle.SetActive(false);
                particle2.SetActive(false);
                firstroomParticle.SetActive(false);
                doorframeParticle.SetActive(false);
                doorframeParticle2.SetActive(false);
            }
        }
        Debug.DrawRay(RightH.transform.position, forward, Color.blue);
    }
}
