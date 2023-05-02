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
    private Player playerHealth;
    private float playerDistance;

    private Transform cowTransform;
    private Cow cowHealth;
    private float cowDistance;
    
    public float howClose;
    public int coolDown;

    public Animator animator;

    public AudioSource source;
    public AudioClip attackClip;
    public AudioClip hurtClip;
    public AudioClip deathClip;

    public void Start()
    {
        health = maxHealth;

        playerTransform = GameObject.FindGameObjectWithTag("Sprout").transform;
        playerHealth = GameObject.FindGameObjectWithTag("Sprout").GetComponent<Player>();

        cowTransform = GameObject.FindGameObjectWithTag("Cow").transform;
        cowHealth = GameObject.FindGameObjectWithTag("Cow").GetComponent<Cow>();
    }

    void Update() 
    {
        playerDistance = Vector3.Distance(playerTransform.position, transform.position);
        cowDistance = Vector3.Distance(cowTransform.position, transform.position);

        // Run animation of the enemy attacking
        animator.SetFloat("Distance Player", playerDistance);
        animator.SetFloat("Distance Cow", cowDistance);

        if (playerDistance <= howClose) 
        {   
            animator.SetBool("Attack", true);
            CoolDownPlayer();
        }
        if (cowDistance <= howClose) 
        {   
            animator.SetBool("Attack", true);
            CoolDownCow();
        }
        else 
        {
            animator.SetBool("Attack", false);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)  
    {
        source.PlayOneShot(attackClip);

        // Player to take damage
        if (collision.gameObject.tag == "Sprout")
        {
            playerHealth.Damage(damage);
        }

        // Cow to take damage
        if (collision.gameObject.tag == "Cow")
        {
            cowHealth.Damage(damage);
        }
    }

    public void Damage(int damage)
    {
        health -= damage;
        source.PlayOneShot(hurtClip);

        if (health <= 0)
        {
            Destroy(gameObject);
        } 
    }

    IEnumerator CoolDownPlayer()
    {
        playerHealth.Damage(damage);

        yield return new WaitForSeconds(coolDown);

        playerHealth.Damage(damage);
    }

    IEnumerator CoolDownCow()
    {
        cowHealth.Damage(damage);

        yield return new WaitForSeconds(coolDown);

        cowHealth.Damage(damage);
    }
}
