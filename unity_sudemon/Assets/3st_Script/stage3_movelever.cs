using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3_movelever : MonoBehaviour
{
    private RaycastHit hit;
    public float RayDistance = 50f;
    public float RayDistance2 = 50f;
    private string windowTag = "movelever";
    public GameObject lever;
    public GameObject door;
    public GameObject person;
    public GameObject person2;
    private Animator anim;
    private Animator anim2;

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

                    anim = this.lever.GetComponent<Animator>();
                    anim.Play("3st_levermove");
                    Invoke("drop", 2f);
                }
            }
        }
    }
    void drop()
    {
        person.SetActive(false);
        person2.SetActive(true);
        anim2 = this.door.GetComponent<Animator>();
        anim2.Play("3st_openFirstDoor2");
        Invoke("dropperson", 4f);
    }

    void dropperson()
    {
        person2.SetActive(false);
    }
}
