using UnityEngine;

namespace PadlockSystem
{
    public class PLInputManager : MonoBehaviour
    {
        [Header("Raycast Pickup Input")]
        public KeyCode interactKey;
        public KeyCode closeKey;

        [Header("Trigger Inputs")]
        public KeyCode triggerInteractKey;

        public static PLInputManager instance;

        private void Awake()
        {
            if (instance != null) { Destroy(gameObject); }
            else { instance = this; DontDestroyOnLoad(gameObject); }
        }
    }
}
