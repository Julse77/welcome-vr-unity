using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastObjectControl : MonoBehaviour
{
    private RaycastHit hit;
    private float RayDistance = 30f;

    private windowOpen_1st PlayAnimation;

    // Update is called once per frame
    void Update()
    {
        // 좌, 우측 컨트톨러 검지
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, RayDistance))
            {
                // ray가 tag에 닿았을 때, 애니메이션 On
                if (hit.collider.tag == "windowOpen_1st")
                {
                    GameObject.Find("rightwindow").GetComponent<windowOpen_1st>().PlayAnimation();
                }
            }
        }
    }
}
