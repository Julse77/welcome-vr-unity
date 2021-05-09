using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace PadlockSystem
{
    public class PadlockController : MonoBehaviour
    {
        private string playerCombi;

        [Header("Your Inputs")]
        [SerializeField] private string yourCombination;
        private bool hasUnlocked;
        private bool isShowing;

        [Header("Trigger Type - ONLY if using a trigger event")]
        [SerializeField] private PadlockTrigger triggerObject;
        [SerializeField] private bool isPadlockTrigger;

        //Hiddie from the inspector because these are only integers to hold some information for later.
        [HideInInspector] public int combinationRow1;
        [HideInInspector] public int combinationRow2;
        [HideInInspector] public int combinationRow3;
        [HideInInspector] public int combinationRow4;

        [Header("Player References")]
        [SerializeField] private Camera mainCamera;
        private PadlockRaycast mainCameraRaycast;

        [Header("Camera GameObject References")]
        [SerializeField] private GameObject cameraPadlock;
        [SerializeField] private Animator lockAnim;

        [Header("World Objects")]
        [SerializeField] private GameObject interactableLock;

        [Header("Unlock Events")]
        [SerializeField] private UnityEvent unlock;

        void Awake()
        {
            mainCameraRaycast = mainCamera.GetComponent<PadlockRaycast>();
            combinationRow1 = 1;
            combinationRow2 = 1;
            combinationRow3 = 1;
            combinationRow4 = 1;
        }

        void UnlockPadlock()
        {
            unlock.Invoke();
        }

        public void ShowPadlock()
        {
            cameraPadlock.SetActive(true);
            isShowing = true;
            mainCameraRaycast.enabled = false;
            PLDisableManager.instance.DisablePlayer(true);
            mainCamera.transform.localEulerAngles = new Vector3(0, 0, 0);
            InteractSound();

            if (isPadlockTrigger)
            {
                triggerObject.interactPrompt.SetActive(false);
                triggerObject.enabled = false;
            }
        }

        void Disable()
        {
            PLDisableManager.instance.DisablePlayer(false);
            mainCameraRaycast.enabled = true;
            cameraPadlock.SetActive(false);
            isShowing = false;

            if (isPadlockTrigger)
            {
                triggerObject.interactPrompt.SetActive(true);
                triggerObject.enabled = true;
            }
        }

        IEnumerator CorrectCombination()
        {
            lockAnim.Play("LockOpen");
            UnlockSound();

            const float waitDuration = 1.2f;
            yield return new WaitForSeconds(waitDuration);

            cameraPadlock.SetActive(false);
            interactableLock.SetActive(false);
            UnlockPadlock();

            PLDisableManager.instance.DisablePlayer(false);
            mainCameraRaycast.enabled = true;
            gameObject.SetActive(false);
        }

        public void CheckCombination()
        {
            playerCombi = combinationRow1.ToString("0") + combinationRow2.ToString("0") + combinationRow3.ToString("0") + combinationRow4.ToString("0");

            if (playerCombi == yourCombination)
            {
                if (!hasUnlocked)
                {
                    StartCoroutine(CorrectCombination());
                    hasUnlocked = true;
                }
            }
        }

        void Update()
        {
            if (isShowing)
            {
                if (Input.GetKeyDown(PLInputManager.instance.closeKey))
                {
                    Disable();
                }
            }
        }

        void InteractSound()
        {
            PLAudioManager.instance.Play("PadlockInteract");
        }

        public void SpinSound()
        {
            PLAudioManager.instance.Play("PadlockSpin");
        }

        public void UnlockSound()
        {
            PLAudioManager.instance.Play("PadlockUnlock");
        }
    }
}
