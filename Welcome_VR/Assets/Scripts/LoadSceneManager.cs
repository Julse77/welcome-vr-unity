using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public void LoadIntro()
    {
        SceneManager.LoadScene("Intro");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("1st_Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    

}
