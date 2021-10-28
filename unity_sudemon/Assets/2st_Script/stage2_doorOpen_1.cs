using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage2_doorOpen_1 : MonoBehaviour
{

    public GameObject firstdooropensound;
    public GameObject door;



    // Update is called once per frame
    public void PlayAnimation()
    {
        door.SetActive(false);
        firstdooropensound.SetActive(true);
        Invoke("Scene_change_1C",2f);
        Invoke("sounddeactivate", 5f);

    }
    void sounddeactivate()
    {
        firstdooropensound.SetActive(false);
    }
    void Scene_change_1C()
    {
        SceneManager.LoadScene("2st_Scene_1C");
    }
}
