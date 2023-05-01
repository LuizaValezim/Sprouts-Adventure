using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cow : MonoBehaviour
{
    public int health;
    public int maxHealth;

    private Transform playerTransform;
    private float distance;
    public float howClose;
    public int coolDown;

    public Animator animator;

    public void Start()
    {
        health = maxHealth;

        playerTransform = GameObject.FindGameObjectWithTag("Sprout").transform;
    }

    void Update() 
    {
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
        yield return new WaitForSeconds(coolDown);
    }
}
