using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage2_roxboxopen : MonoBehaviour
{
    private Animator anim;

    public GameObject Object231;
    public GameObject handpicture;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Key")
        {
            //anim = this.paetong_in.GetComponent<Animator>();
            //anim.Play("1st_contPaetong");
            //키와 닿으면 상자열리는 애니메이션
            handpicture.SetActive(true);
            anim = this.Object231.GetComponent<Animator>();
            anim.Play("2st_openroxbox");
            Invoke("Scene3", 2f);

        }
    }
    void Scene3()
    {
        SceneManager.LoadScene("2st_Scene_1C");
    }
}
