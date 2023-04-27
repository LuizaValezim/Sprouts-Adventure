using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutPediaController : MonoBehaviour
{

    [SerializeField] private Sproutpedia sproutpedia;
    
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)){
            if (sproutpedia.isActiveAndEnabled == false){
                sproutpedia.Show();
            } else {
                sproutpedia.Hide();
            }
        }
        
    }
}
