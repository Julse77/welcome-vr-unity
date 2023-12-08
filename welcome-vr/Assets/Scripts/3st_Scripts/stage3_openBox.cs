using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage3_openBox : MonoBehaviour
{
    private Animator anim;
    //public GameObject firstdooropensound;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("3st_openBox", 0, 0.0f);
            Invoke("LoadNextScene", 1f);
            //firstdooropensound.SetActive(true);
            //Invoke("sounddeactivate", 5f);
        }
    }
    // void sounddeactivate()
    // {
    //     firstdooropensound.SetActive(false);
    // }

    void LoadNextScene()
    {
        SceneManager.LoadScene("3st_Scene_1C");
    } 
}
