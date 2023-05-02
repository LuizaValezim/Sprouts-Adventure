using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] public int health;
    public int maxHealth;
    
    private AudioSource source;
    public AudioClip startGameClip;

    [SerializeField] private GameObject emotes;
    [SerializeField] private GameObject inventory;
    
    // Start is called before the first frame Damage
    public void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void Damage(int damage)
    {
        health -= damage;

        // Change the Sprite Renderer for a moment when hit
        //GameObject.FindGameObjectWithTag("Sprout").GetComponent<SpriteRenderer>().color = Color.red;
        //GameObject.FindGameObjectWithTag("Sprout").GetComponent<SpriteRenderer>().color = Color.white;

        if (health == 0) 
        {
            SceneManager.LoadScene("GameOver_Sprout");
        }
    }
}