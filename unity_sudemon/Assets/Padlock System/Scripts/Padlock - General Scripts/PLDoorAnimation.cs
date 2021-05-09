using UnityEngine;

namespace PadlockSystem
{
    public class PLDoorAnimation : MonoBehaviour
    {
        private Animator anim;

        private void Start()
        {
            anim = GetComponent<Animator>();
        }

        public void PlayAnimation()
        {
            if (null != anim)
            {
                anim.Play("DoorOpen", 0, 0.0f);
            }
        }
    }
}
