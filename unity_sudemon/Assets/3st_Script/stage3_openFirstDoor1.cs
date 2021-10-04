using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3_openFirstDoor1 : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("3st_openFirstDoor1", 0, 0.0f);
        }
    }
}
