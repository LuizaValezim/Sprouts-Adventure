using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutPediaController : MonoBehaviour
{

    [SerializeField] private Sproutpedia sproutpedia;
    [SerializeField] private GameObject emotes;
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject panel;

    public void Start() 
    {
        panel.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (sproutpedia.isActiveAndEnabled == false)
            {
                Pause();
            } 
            else 
            {
                Resume();
            }
        }
    }

    void Resume() 
    {
        sproutpedia.Hide();
        emotes.SetActive(true);
        inventory.SetActive(true);
        panel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        sproutpedia.Show();
        emotes.SetActive(false);
        inventory.SetActive(false);
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
}