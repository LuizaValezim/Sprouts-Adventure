using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowHealth : MonoBehaviour
{
    public Cow cow; 
    private int health, maxHealth;
    private float percentileHealth;
    public Sprite sp1, sp2, sp3, sp4, sp5, sp6;
    public Image img;

    public void Start()
    {
        maxHealth = cow.maxHealth;
    }

    public void Update()
    {   
        health = cow.health;

        if (maxHealth == 20) 
        {
            if (health == 20) { GetComponent<SpriteRenderer>().sprite = sp6; img.sprite = sp6; } 
            else if (health == 17) { GetComponent<SpriteRenderer>().sprite = sp5; img.sprite = sp5; } 
            else if (health == 15) { GetComponent<SpriteRenderer>().sprite = sp4; img.sprite = sp4; } 
            else if (health == 10) { GetComponent<SpriteRenderer>().sprite = sp3; img.sprite = sp3; } 
            else if (health == 7) { GetComponent<SpriteRenderer>().sprite = sp2; img.sprite = sp2; } 
            else if (health == 5) { GetComponent<SpriteRenderer>().sprite = sp1; img.sprite = sp1; } 
            else if (health == 0) Destroy(gameObject);
        }

    }
}