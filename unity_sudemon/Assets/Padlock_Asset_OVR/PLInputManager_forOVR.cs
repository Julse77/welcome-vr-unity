using UnityEngine;

namespace PadlockSystem
{
    public class PLInputManager_forOVR : MonoBehaviour
    {
        [Header("Raycast Pickup Input")]
        public OVRInput.Button interactKey;
        public OVRInput.Button closeKey;

        [Header("Trigger Inputs")]
        public OVRInput.Button triggerInteractKey;

        public static PLInputManager_forOVR instance;

        private void Awake()
        {
            if (instance != null) { Destroy(gameObject); }
            else { instance = this; DontDestroyOnLoad(gameObject); }
        }
    }
}
