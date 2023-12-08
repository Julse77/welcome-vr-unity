using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage3_lever : MonoBehaviour
{
    private Animator anim;
    public GameObject lever1;
    public GameObject lever2;


    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "lever")
        {
            lever1.SetActive(true);
            lever2.SetActive(false);
            anim = this.lever1.GetComponent<Animator>();
            anim.Play("3st_lever");
            Invoke("Scene3", 2f);
        }

    }
    void Scene3()
    {
        SceneManager.LoadScene("3st_Scene_1C_1");
    }
}
