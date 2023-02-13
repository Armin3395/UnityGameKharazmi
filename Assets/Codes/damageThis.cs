using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageThis : MonoBehaviour
{
    public Animator CylinderAnim;

    private void Start()
    {
        CylinderAnim = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.layer == 12)
        {
            if (collision.gameObject.layer == 13)
            {
                CylinderAnim.SetTrigger("moveLeft");
            }
        }
    }
}
