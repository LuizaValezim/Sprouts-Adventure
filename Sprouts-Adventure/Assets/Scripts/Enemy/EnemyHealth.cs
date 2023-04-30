using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Enemy enemy; 
    private int health, maxHealth;
    private float percentileHealth;
    public Sprite sp1, sp2, sp3, sp4, sp5, sp6;

    public void Start()
    {
        maxHealth = enemy.maxHealth;
    }

    public void Update()
    {   
        health = enemy.health;

        if (maxHealth == 10) 
        {
            if (health == 10) GetComponent<SpriteRenderer>().sprite = sp6; 
            else if (health == 9) GetComponent<SpriteRenderer>().sprite = sp5; 
            else if (health == 8) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 7) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 6) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 5) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 4) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 3) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 2) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 1) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 0) Destroy(gameObject);
        }

        if (maxHealth == 9) 
        {
            if (health == 9) GetComponent<SpriteRenderer>().sprite = sp6; 
            else if (health == 8) GetComponent<SpriteRenderer>().sprite = sp5; 
            else if (health == 7) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 6) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 5) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 4) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 3) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 2) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 1) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 0) Destroy(gameObject);
        }

        if (maxHealth == 8) 
        {
            if (health == 8) GetComponent<SpriteRenderer>().sprite = sp6; 
            else if (health == 7) GetComponent<SpriteRenderer>().sprite = sp5; 
            else if (health == 6) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 5) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 4) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 3) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 2) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 1) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 0) Destroy(gameObject);
        }

        if (maxHealth == 7) 
        {
            if (health == 7) GetComponent<SpriteRenderer>().sprite = sp6; 
            else if (health == 6) GetComponent<SpriteRenderer>().sprite = sp5; 
            else if (health == 5) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 4) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 3) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 2) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 1) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 0) Destroy(gameObject);
        }

        if (maxHealth == 6) 
        {
            if (health == 6) GetComponent<SpriteRenderer>().sprite = sp6; 
            else if (health == 5) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 4) GetComponent<SpriteRenderer>().sprite = sp3; 
            else if (health == 3) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 2) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 1) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 0) Destroy(gameObject);
        }

        if (maxHealth == 5) 
        {
            if (health == 5) GetComponent<SpriteRenderer>().sprite = sp6; 
            else if (health == 4) GetComponent<SpriteRenderer>().sprite = sp5; 
            else if (health == 3) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 2) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 1) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 0) Destroy(gameObject);
        }

        if (maxHealth == 4) 
        {
            if (health == 4) GetComponent<SpriteRenderer>().sprite = sp6; 
            else if (health == 3) GetComponent<SpriteRenderer>().sprite = sp4; 
            else if (health == 2) GetComponent<SpriteRenderer>().sprite = sp2; 
            else if (health == 1) GetComponent<SpriteRenderer>().sprite = sp1; 
            else if (health == 0) Destroy(gameObject);
        }
    }
}