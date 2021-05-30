using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour
{
    public GameObject Headcam;
    public GameObject particle;
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
        Vector3 forward = Headcam.transform.TransformDirection(Vector3.forward * 1000);
        if(Physics.Raycast(Headcam.transform.position,forward,out hit))
        {
            if(hit.transform.tag=="Padlock")
            {
                particle.SetActive(true);
            }
            else
            {
                particle.SetActive(false);
            }
        }
        Debug.DrawRay(Headcam.transform.position, forward, Color.blue);
    }
}
