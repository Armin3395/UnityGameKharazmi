using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    string CurrentScene;
    public void ChangeScene(string SceneName)
    {
        //CurrentScene = SceneManager.GetActiveScene().name;
        //EditorSceneManager.OpenScene(SceneName);
        SceneManager.LoadScene(SceneName);
        if (SceneName == "Menu")
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        //SceneManager.UnloadSceneAsync(CurrentScene);
    }
}
