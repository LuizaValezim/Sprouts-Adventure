using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutPediaController : MonoBehaviour
{

    [SerializeField] private Sproutpedia sproutpedia;
    [SerializeField] private GameObject emotes;
    [SerializeField] private GameObject inventory;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)){
            if (sproutpedia.isActiveAndEnabled == false){
                sproutpedia.Show();
                emotes.SetActive(false);
                inventory.SetActive(false);
            } else {
                sproutpedia.Hide();
                emotes.SetActive(true);
                inventory.SetActive(true);
            }
        }
    }
}
