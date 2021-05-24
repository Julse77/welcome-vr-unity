using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PadlockSystem
{
    public class PlayerPadlock : MonoBehaviour
    {
        private RaycastHit Collided_object; // 충돌된 객체
        //private GameObject currentObject;   // 가장 최근에 충돌한 객체를 저장하기 위한 객체

        public float raycastDistance = 100f; // 레이저 포인터 감지 거리


        // Update is called once per frame
        void Update()
        {
            // 충돌 감지 시
            if (Physics.Raycast(transform.position, transform.forward, out Collided_object, raycastDistance))
            {
                // 충돌 객체의 태그가 Button인 경우
                if (Collided_object.collider.gameObject.CompareTag("row1"))
                {
                    // 오큘러스 고 리모콘에 큰 동그라미 부분을 누를 경우
                    if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
                    {
                        // 버튼에 등록된 onClick 메소드를 실행한다.
                        transform.Rotate(0, 0, transform.rotation.z + 40);
                    }
                 
                }
            }


        }
    }
}
