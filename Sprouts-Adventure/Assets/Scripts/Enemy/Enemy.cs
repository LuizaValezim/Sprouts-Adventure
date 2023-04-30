using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int damage;

    private Transform playerTransform;
    public PlayerHealth playerHealth;
    private float distance;
    public float howClose;
    public int coolDown;

    public Animator animator;

    public void Start()
    {
        health = maxHealth;

        playerTransform = GameObject.FindGameObjectWithTag("Sprout").transform;
        playerHealth = GameObject.FindGameObjectWithTag("Sprout").GetComponent<PlayerHealth>();

    }

    void Update() 
    {
        distance = Vector3.Distance(playerTransform.position, transform.position);

        // Run animation of the enemy attacking
        animator.SetFloat("Distance", distance);

        if (distance <= howClose) 
        {   
            animator.SetBool("Attack", true);
            CoolDown();
        }
        else 
        {
            animator.SetBool("Attack", false);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)  
    {
        // Player to take damage
        if (collision.gameObject.tag == "Sprout")
        {
            playerHealth.Damage(damage);
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

    IEnumerator CoolDown()
    {
        playerHealth.Damage(damage);

        yield return new WaitForSeconds(coolDown);

        playerHealth.Damage(damage);
    }
}
