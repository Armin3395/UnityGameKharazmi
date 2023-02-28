using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public Scenes SceneScript;
    private void OnTriggerEnter(Collider other)
    {
        SceneScript.ChangeScene("Menu");
    }
}
