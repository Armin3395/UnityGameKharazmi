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
        //SceneManager.UnloadSceneAsync(CurrentScene);
    }
}
