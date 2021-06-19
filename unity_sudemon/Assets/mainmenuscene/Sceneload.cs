using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneload : MonoBehaviour
{
    // Start is called before the first frame update
    public void GOintro()
    {
        SceneManager.LoadScene("intro");
    }
    public void GOmainmenu()
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
    public void tutorialstart()
    {
        SceneManager.LoadScene("tutorial");
    }

}
