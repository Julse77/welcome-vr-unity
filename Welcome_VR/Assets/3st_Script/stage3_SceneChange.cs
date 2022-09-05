using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage3_SceneChange : MonoBehaviour
{
    public GameObject image1;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerHand")
        {
            image1.SetActive(true);
            Invoke("endingScene", 3f);
        }

    }
    void endingScene()
    {
        SceneManager.LoadScene("ending");
    }
}
