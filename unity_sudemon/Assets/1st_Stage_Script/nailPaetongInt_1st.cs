using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nailPaetongInt_1st : MonoBehaviour
{
    // Collider 충돌 시 이벤트 발생
    private void OnCollisionEnter(Collision collision)
    {
        // paetongButton 태그의 gameObject와 충돌 시
        if (collision.gameObject.tag == "paetongButton")
        {
            OpenPaetong();
        }        
    }

    void OpenPaetong()
    {
        // paetong_in 이름의 GameObject의 컴포넌트 conPaetong_1st의 PlayAnimation 함수 실행
        GameObject.Find("paetong_in").GetComponent<conPaetong_1st>().PlayAnimation();
    }

}
