using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    //this script is used for changing and moving between scenes
    string CurrentScene;
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        if (SceneName == "Menu")
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
