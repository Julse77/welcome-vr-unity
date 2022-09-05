using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3_openSecondDoor1 : MonoBehaviour
{
    private Animator anim;
    //private GameObject door1, door2;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("3st_openSecondDoor1", 0, 0.0f);
            GameObject.Find("rightDoor1").GetComponent<stage3_openSecondDoor2>().PlayAnimation();
            GameObject.Find("leftDoor1").GetComponent<stage3_openSecondDoor3>().PlayAnimation();  
        }
    }

}
