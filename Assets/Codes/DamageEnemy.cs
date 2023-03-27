using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    int HP = 100;

   /* public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 13)
        {
            HP -= 20;
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 13)
        {
            HP -= 10;
        }
    }

    void Update()
    {
        if (HP <= 0)
        {
            //die
            GetComponentInParent<Transform>().gameObject.SetActive(false);
        }
    }
}
