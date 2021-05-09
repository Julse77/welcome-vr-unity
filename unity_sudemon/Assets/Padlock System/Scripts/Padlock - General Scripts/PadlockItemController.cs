using UnityEngine;

namespace PadlockSystem
{
    public class PadlockItemController : MonoBehaviour
    {
        [SerializeField] private PadlockController _padlockController;

        public void ShowKeypad()
        {
            _padlockController.ShowPadlock();
        }
    }
}
