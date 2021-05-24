using UnityEngine;

namespace PadlockSystem
{
    public class SpinnerScript : MonoBehaviour
    {        
        [Header("Padlock Controller Reference")]
        [SerializeField] private PadlockController _padlockController;

        [Header("Combination Settings")]
        private int spinnerNumber;
        private int spinnerLimit;

        [Header("Padlock Row")]      
        [SerializeField] private PadlockRow _row;

        private enum PadlockRow { row1, row2, row3, row4 }

        

        private void Awake()
        {
            spinnerNumber = 1;
            spinnerLimit = 9;
        }

        void Spin()
        {
            transform.Rotate(0, 0, transform.rotation.z + 40);
            _padlockController.SpinSound();
            Rotate();
        }

        /*
        void Update()
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1.0f))
            {
                if (hit.collider.gameObject.CompareTag("row1"))
                {
                    if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
                    {
                        Debug.Log("111111111");
                        SpinnerScript spinnerScript = hit.collider.GetComponent<SpinnerScript>();
                        if (spinnerScript != null)
                        {
                            spinnerScript.Spin();
                            Debug.Log("22222222");
                        }
                        Debug.Log("33333333");
                    }
                }
                
            }*/
        


        /*
        void OnMouseDown()
        {
            transform.Rotate(0, 0, transform.rotation.z + 40);
            _padlockController.SpinSound();
            Rotate();
        }
        */

        void Rotate()
        {
            if (spinnerNumber <= spinnerLimit - 1)
            {
                spinnerNumber++;
            }
            else
            {
                spinnerNumber = 1;
            }

            switch (_row)
            {
                case PadlockRow.row1:
                    _padlockController.combinationRow1 = spinnerNumber;
                    _padlockController.CheckCombination();
                    break;
                case PadlockRow.row2:
                    _padlockController.combinationRow2 = spinnerNumber;
                    _padlockController.CheckCombination();
                    break;
                case PadlockRow.row3:
                    _padlockController.combinationRow3 = spinnerNumber;
                    _padlockController.CheckCombination();
                    break;
                case PadlockRow.row4:
                    _padlockController.combinationRow4 = spinnerNumber;
                    _padlockController.CheckCombination();
                    break;
            }
        }
    }
}


