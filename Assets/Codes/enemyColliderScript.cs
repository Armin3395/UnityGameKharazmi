using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyColliderScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 14)
        {
            //make enemy look at player and move towards it
        }
    }

}
