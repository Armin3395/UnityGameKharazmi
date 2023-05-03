using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyColliderScript : MonoBehaviour
{
    public Transform EnemyTr;
    public Transform playerTr;
    public Animator EnemyAnim;
    public float speed = 0f;
    float atckcldwn = 1f;
    float lastatck = 0f;
    bool canMove = false;

    /*public void OnTriggerEnter(Collider other)
    {
            Debug.Log("...");
        if (other.gameObject.layer == 14)
        {
            EnemyTr.LookAt(playerTr.position);
            EnemyTr.Translate(0f, 0f, speed * Time.deltaTime);
        }
    }*/
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 14)
        {
            EnemyTr.LookAt(playerTr.position);
            if ((EnemyTr.position - playerTr.position).magnitude > 12f)
            {
                canMove = true;
            }
            if (Time.time - lastatck >= atckcldwn)
            {
                EnemyAnim.SetTrigger("AttackTrig");
                lastatck = Time.time;
            }
        }
    }
    private void Update()
    {
        if (canMove)
        {   //movetoplayer = new(playerTr.position.x, playerTr.position.y, playerTr.position.z);
            //Vector3.MoveTowards(EnemyTr.position, playerTr.position, 5f);
            EnemyTr.Translate(Vector3.forward * Time.deltaTime * 8);
        }
        if (!((EnemyTr.position - playerTr.position).magnitude > 12f))
        {
            canMove = false;
        }
    }

}
