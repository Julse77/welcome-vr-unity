using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    private Animator anim;
    public GameObject OpenWindowSound;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void PlayOpenWindowSound()
    {
        OpenWindowSound.SetActive(true);
        OpenWindowSound.GetComponent<AudioSource>().Play(0);
        OpenWindowSound.SetActive(false);
    }

    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("OpenWindow", 0, 0.0f);
            PlayOpenWindowSound();
        }
    }
}
