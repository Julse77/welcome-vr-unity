using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen_1st : MonoBehaviour
{
    private Animator anim;
    public GameObject room2DoorAudio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("1st_openFirstDoor", 0, 0.0f);
            room2DoorAudio.SetActive(true);
        }
    }
}
