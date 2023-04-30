using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth;
    
    // Start is called before the first frame Damage
    public void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void Damage(int damage)
    {
        health -= damage;

        if (health > 0)
        {
            // change heart sprite
            // change sprout sprite to red
            // add audio source of damage
        } 
        else 
        {
            // player is dead
        }
    }
}