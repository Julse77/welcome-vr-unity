using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2_doorOpen_1 : MonoBehaviour
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
            anim.Play("2st_openFirstDoor", 0, 0.0f);
        }
    }
}
