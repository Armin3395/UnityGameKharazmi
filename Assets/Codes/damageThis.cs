using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class damageThis : MonoBehaviour
{
    public Animator CylinderAnim;
    int HP = 100;
    bool canGo = true;


    private void Update()
    {
        if (HP <= 0)
        {
            if (canGo)
            {
            CylinderAnim.SetTrigger("moveLeft");
                canGo = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 13)
        {
            HP -= 15;
        }
    }
}
