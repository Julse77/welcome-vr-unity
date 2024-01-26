using UnityEngine;

public class ControlPaetong : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("1st_conPaetong", 0, 0.0f);
        }
    }
}
