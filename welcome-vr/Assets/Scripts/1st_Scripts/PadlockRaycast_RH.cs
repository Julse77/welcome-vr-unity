using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PadlockSystem;
using System.Runtime.CompilerServices;

public class PadlockRaycast_RH : MonoBehaviour
{
    // Padlock_Camera_Mechanism 하위 Padlock_Combination
    [Header("First Padlock's Rows")]
    public SpinnerScript first_Row1, first_row2, first_Row3, first_Row4 = new SpinnerScript();
    [Header("Second Padlock's Rows")]
    public SpinnerScript second_Row1, second_Row2, second_Row3, second_Row4 = new SpinnerScript();
    [Header("Third Padlock's Rows")]
    public SpinnerScript third_Row1, third_Row2, third_Row3, third_Row4 = new SpinnerScript();
    [Header("Last Padlock's Rows")]
    public SpinnerScript last_Row1, last_Row2, last_Row3, last_Row4 = new SpinnerScript();

    RaycastHit hit;
    private float RayDistance = 15f;

    void Update()
    {
        // 우측 컨트롤러 스틱
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            RaySpinFunc();
        }
    }

    private void RaySpinFunc()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, RayDistance))
        {
            // 맞는 태그에 Ray가 닿으면 돈다
            if (hit.collider.tag == "FirstRow1")
            {
                first_Row1.Spin();
            }

            if (hit.collider.tag == "FirstRow2")
            {
                first_row2.Spin();
            }

            if (hit.collider.tag == "FirstRow3")
            {
                first_Row3.Spin();
            }

            if (hit.collider.tag == "FirstRow4")
            {
                first_Row4.Spin();
            }

            if (hit.collider.tag == "SecondRow1")
            {
                second_Row1.Spin();
            }

            if (hit.collider.tag == "SecondRow2")
            {
                second_Row2.Spin();
            }

            if (hit.collider.tag == "SecondRow3")
            {
                second_Row3.Spin();
            }

            if (hit.collider.tag == "SecondRow4")
            {
                second_Row4.Spin();
            }

            if (hit.collider.tag == "ThirdRow1")
            {
                third_Row1.Spin();
            }

            if (hit.collider.tag == "ThirdRow2")
            {
                third_Row2.Spin();
            }

            if (hit.collider.tag == "ThirdRow3")
            {
                third_Row3.Spin();
            }

            if (hit.collider.tag == "ThirdRow4")
            {
                third_Row4.Spin();
            }

            if (hit.collider.tag == "LastRow1")
            {
                last_Row1.Spin();
            }

            if (hit.collider.tag == "LastRow2")
            {
                last_Row2.Spin();
            }

            if (hit.collider.tag == "LastRow3")
            {
                last_Row3.Spin();
            }

            if (hit.collider.tag == "LastRow4")
            {
                last_Row4.Spin();
            }
        }
    }
}