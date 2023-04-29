using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
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
            // player is hurt
        } 
        else 
        {
            // player is dead
        }
    }
}