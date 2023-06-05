using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3_openSecondDoor3 : MonoBehaviour
{
    private Animator anim;
    public GameObject openSound;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("3st_openSecondDoor3", 0, 0.0f);
            openSound.SetActive(true);
        }
    }

}
