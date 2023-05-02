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

    public Transform destinationTransform;
    private float destinationDistance;
    public float howClose;
    public int coolDown;

    public Animator animator;

    private AudioSource source;
    public AudioClip hurtClip;

    public void Start()
    {
        health = maxHealth;
    }

    void Update() 
    {
        Debug.Log(health);

        destinationDistance = Vector3.Distance(destinationTransform.position, transform.position);

        Debug.Log("Distance: " + destinationDistance.ToString());

        if (destinationDistance <= howClose) 
        {
            SceneManager.LoadScene("Win");
        }

    }

    public void Damage(int damage)
    {
        health -= damage;

        source = GameObject.FindGameObjectWithTag("Cow").GetComponent<AudioSource>();
        source.PlayOneShot(hurtClip);

        Debug.Log("Cow's Life: " + health.ToString());

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver_Betina");
        } 
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(coolDown);
    }
}
