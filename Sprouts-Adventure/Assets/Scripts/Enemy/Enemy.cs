using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int maxHealth;
    private EnemyHealth enemyHealth;

    private Transform playerTransform;
    //public PlayerHealth playerHealth;
    private float distance;
    public float howClose;

    public Animator animator;

    public void Start()
    {
        health = maxHealth;

        playerTransform = GameObject.FindGameObjectWithTag("Sprout").transform;
    }

    void Update() 
    {
        distance = Vector3.Distance(playerTransform.position, transform.position);

        // Run animation of the enemy attacking
        animator.SetFloat("Distance", distance);

        if (distance <= howClose) 
        {   
            animator.SetBool("Attack", true);
            // Make player receive damage
            // playerHealth =.Damage();
            //transform.LookAt(playerTransform);
        }
        else 
        {
            animator.SetBool("Attack", false);
        }
    }

    public void Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        } 
    }
}
