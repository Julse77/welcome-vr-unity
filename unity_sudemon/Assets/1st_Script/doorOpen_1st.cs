using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorOpen_1st : MonoBehaviour
{
    private Animator anim;
    public GameObject room2DoorAudio;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("1st_openFirstDoor", 0, 0.0f);
            room2DoorAudio.SetActive(true);
            Invoke("LoadNextScene", 1f);
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("1st_Scene_1C");
    }
}
