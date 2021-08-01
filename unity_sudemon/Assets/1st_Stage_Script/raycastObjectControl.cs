using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastObjectControl : MonoBehaviour
{
    // 변수선언
    private RaycastHit hit;
    public float RayDistance = 50f;
    public float RayDistance2 = 50f;
    private string windowTag = "windowOpen_1st";
    private string box1Tag = "box1Open_1st";
    private string box2Tag = "box1Open_2st";

    private windowOpen_1st PlayAnimation;

    // Update is called once per frame
    void Update()
    {
        // 컨트롤러 양손 검지파트를 누를 시
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            // ray 발사
            if (Physics.Raycast(transform.position, transform.forward, out hit, RayDistance))
            {
                // ray가 tag에 닿았을 때, 애니메이션 On
                if (hit.collider.CompareTag(windowTag))
                {                    
                    GameObject.Find("rightwindow").GetComponent<windowOpen_1st>().PlayAnimation();
                    Debug.Log("창문 열림!");
                }
            }
        }

        // 컨트롤러 A 버튼 누를 시
        // if (OVRInput.Get(OVRInput.Button.One))
        // {
        //     // ray 발사
        //     if (Physics.Raycast(transform.position, transform.forward, out hit, RayDistance2))
        //     {
        //         // ray가 tag에 닿았을 때, 애니메이션 On
        //         if (hit.collider.CompareTag(box1Tag))
        //         {
        //             GameObject.Find("boxLid1").GetComponent<openBox_1st>().PlayAnimation();
        //         }

        //         if (hit.collider.CompareTag(box2Tag))
        //         {
        //             GameObject.Find("boxLid2").GetComponent<openBox2_1st>().PlayAnimation();
        //         }
        //     }
        // }
    }
}
