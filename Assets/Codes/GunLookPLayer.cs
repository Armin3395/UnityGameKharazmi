using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for a turret gun that should be rotated to look at player and shoot the player
public class GunLookPLayer : MonoBehaviour
{
    public Transform PlayerT;
    void Update()
    {
        transform.LookAt(PlayerT, Vector3.up);
        transform.localEulerAngles = new(-90, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
