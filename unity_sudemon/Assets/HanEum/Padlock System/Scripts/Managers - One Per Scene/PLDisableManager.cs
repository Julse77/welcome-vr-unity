using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

namespace PadlockSystem
{
    public class PLDisableManager : MonoBehaviour
    {
        public static PLDisableManager instance;

        [SerializeField] private FirstPersonController player;
        [SerializeField] private Image crosshair; 

        void Awake()
        {
            if (instance != null) { Destroy(gameObject); }
            else { instance = this; DontDestroyOnLoad(gameObject); }
        }

        public void DisablePlayer(bool disable)
        {
            if (disable)
            {
                player.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                crosshair.enabled = false;
            }

            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                player.enabled = true;
                crosshair.enabled = true;
            }
        }
    }
}
