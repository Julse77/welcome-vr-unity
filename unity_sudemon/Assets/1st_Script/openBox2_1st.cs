using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openBox2_1st : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        if (null != anim)
        {
            anim.Play("1st_openBox2", 0, 0.0f);
            Invoke("LoadNextScene", 1f);
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("1st_Scene_3C");
    }  
}
