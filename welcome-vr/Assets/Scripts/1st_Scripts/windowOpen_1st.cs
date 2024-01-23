using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowOpen_1st : MonoBehaviour
{
    private Animator anim;
    public GameObject room2WindowAudio;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("1st_openWindow", 0, 0.0f);
            room2WindowAudio.SetActive(true);
        }
    }
}
