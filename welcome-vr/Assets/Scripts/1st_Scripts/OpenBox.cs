using UnityEngine;

public class OpenBox : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenFirstBox()
    {
        if (null != anim)
        {
            anim.Play("OpenFirstBox", 0, 0.0f);
        }
    }
    public void OpenSecondBox()
    {
        if (null != anim)
        {
            anim.Play("OpenSecondBox", 0, 0.0f);
        }
    }

}
