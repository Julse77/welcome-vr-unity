using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage2_SceneChange : MonoBehaviour
{
    public GameObject image1;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {
            Invoke("Scene3", 5f);
        }

    }
    void Scene3()
    {
        SceneManager.LoadScene("3st_Scene");
    }
}
