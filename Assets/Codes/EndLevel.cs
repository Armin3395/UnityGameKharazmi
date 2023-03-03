using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    //if a gameobject hits the collider attached to the gameobject this script is attached to, the player wins
    public Scenes SceneScript;
    private void OnTriggerEnter(Collider other)
    {
        SceneScript.ChangeScene("Menu");
    }
}
