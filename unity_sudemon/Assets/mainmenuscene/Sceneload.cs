using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneload : MonoBehaviour
{
    // Start is called before the first frame update
    public void GOmain()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void Gamestart()
    {
        SceneManager.LoadScene("1st_stage_Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
