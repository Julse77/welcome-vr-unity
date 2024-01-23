using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator anim;
    public GameObject OpenDoorSound;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void PlayOpenDoorSound()
    {
        OpenDoorSound.SetActive(true);
        OpenDoorSound.GetComponent<AudioSource>().Play(0);
        OpenDoorSound.SetActive(false);
    }

    public void PlayOpenFirstDoor()
    {
        if (null != anim)
        {
            anim.Play("OpenFirstDoor", 0, 0.0f);
            PlayOpenDoorSound();
        }
    }

    public void PlayOpenSecondDoor()
    {
        if (null != anim)
        {
            anim.Play("OpenSecondDoor", 0, 0.0f);
            PlayOpenDoorSound();
        }
    }

    public void PlayOpenThirdDoor()
    {
        if (null != anim)
        {
            anim.Play("OpenThirdDoor", 0, 0.0f);
            PlayOpenDoorSound();
        }
    }

    public void PlayOpenLastDoor()
    {
        if (null != anim)
        {
            anim.Play("OpenLastDoor", 0, 0.0f);
            PlayOpenDoorSound();
        }
    }
}
