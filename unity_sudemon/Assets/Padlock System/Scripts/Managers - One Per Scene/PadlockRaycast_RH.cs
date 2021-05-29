using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PadlockSystem;

public class PadlockRaycast_RH : MonoBehaviour
{
    // Padlock_Camera_Mechanism 하위 Padlock_Combination
    public SpinnerScript row1, row2, row3, row4 = new SpinnerScript();

    RaycastHit hit;
    public float RayDistance = 15f;

    void Update()
    {
        // 우측 컨트롤러 스틱
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {            
            if(Physics.Raycast(transform.position, transform.forward, out hit, RayDistance))
            {
                // 맞는 태그에 Ray가 닿으면 돈다
                if (hit.collider.tag == "Row1")
                {
                    row1.Spin();
                }

                else if (hit.collider.tag == "Row2")
                {
                    row2.Spin();
                }

                else if (hit.collider.tag == "Row3")
                {
                    row3.Spin();
                }

                else if (hit.collider.tag == "Row4")
                {
                    row4.Spin();
                }

                else{

                }

            }
        }
    }

}
