using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastObjectControl : MonoBehaviour
{
    // 변수선언
    private RaycastHit hit;
    public float RayDistance = 50f;
    private string tagName = "windowOpen_1st";

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
                if (hit.collider.CompareTag(tagName))
                {
                    Debug.Log("창문 열림!");
                    GameObject.Find("rightwindow").GetComponent<windowOpen_1st>().PlayAnimation();
                }
            }
        }
    }
}
