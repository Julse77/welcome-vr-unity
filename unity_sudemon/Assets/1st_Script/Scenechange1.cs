using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange1 : MonoBehaviour
{
    public GameObject image1;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {
            image1.SetActive(true);
            Invoke("Scene2", 5f);
            
        }

    }
    void Scene2()
    {
        SceneManager.LoadScene("2st_Scene");
    }
}
