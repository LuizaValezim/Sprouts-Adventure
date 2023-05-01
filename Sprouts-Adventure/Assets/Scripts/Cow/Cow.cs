using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("GameOver");
        } 
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(coolDown);
    }
}
