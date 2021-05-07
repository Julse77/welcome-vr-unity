using UnityEngine;

namespace PadlockSystem
{
    public class PadlockTrigger : MonoBehaviour
    {
        [Header("Padlock Controller Object")]
        [SerializeField] private PadlockController padlockController;

        [Header("UI Prompt")]
        public GameObject interactPrompt;    

        private const string playerTag = "Player";
        private bool canUse;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {
                canUse = true;
                interactPrompt.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(playerTag))
            {
                canUse = false;
                interactPrompt.SetActive(false);
            }
        }

        private void Update()
        {
            if (canUse)
            {
                if (Input.GetKeyDown(PLInputManager.instance.triggerInteractKey))
                {
                    padlockController.ShowPadlock();
                }
            }
        }
    }
}
