using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut_openDoor : MonoBehaviour
{
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("tutorial_openDoor", 0, 0.0f);
        }
    }
}
