using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int health;
    public int maxHealth;
    public GameObject gameOver;

    [SerializeField] private GameObject emotes;
    [SerializeField] private GameObject inventory;
    
    // Start is called before the first frame Damage
    public void Start()
    {
        health = maxHealth;
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    public void Damage(int damage)
    {
        health -= damage;

        if (health == 0) 
        {
            gameOver.SetActive(true);
            emotes.SetActive(false);
            inventory.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}