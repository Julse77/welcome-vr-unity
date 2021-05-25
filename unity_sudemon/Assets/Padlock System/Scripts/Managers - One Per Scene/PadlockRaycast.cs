using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace PadlockSystem
{
    public class PadlockRaycast : MonoBehaviour
    {
        private SpinnerScript spinnerScript;

        [Header("Raycast References")]
        [SerializeField] private int rayLength = 5;
        [SerializeField] private LayerMask layerMaskInteract;
        [SerializeField] private LayerMask layerToExclude;
        private PadlockItemController rayCastedObj;

        [Header("Crosshair References")]
        [SerializeField] private Image crosshair;
        private bool isCrosshairActive;
        private bool doOnce;

        private const string padlockTag = "Padlock";
        private const string padlockCam = "Padlock_Cam";
        private const string row1 = "row1";


        void Update()
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            {
                int mask = 1 << layerToExclude.value | layerMaskInteract.value;

                if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
                {
                    if (hit.collider.CompareTag(padlockTag))
                    {
                        if (!doOnce)
                        {
                            rayCastedObj = hit.collider.gameObject.GetComponent<PadlockItemController>();
                            CrosshairChange(true);
                        }

                        isCrosshairActive = true;
                        doOnce = true;

                        if (OVRInput.Get(OVRInput.Button.One))
                        {
                            rayCastedObj.ShowKeypad();
                        }
                    }

                    if (hit.collider.CompareTag(padlockCam))
                    {
                        if (hit.collider.CompareTag(row1))
                        {
                            if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
                            {
                                Debug.Log("돌아라 제발");
                                spinnerScript.Spin();
                            }
                        }
                    }
                    


                }
                else
                {
                    if (isCrosshairActive)
                    {
                        CrosshairChange(false);
                        doOnce = false;
                    }
                }
            }
        }

        void CrosshairChange(bool on)
        {
            if (on && !doOnce)
            {
                crosshair.color = Color.red;
            }
            else
            {
                crosshair.color = Color.white;
                isCrosshairActive = false;
            }
        }
    }
}