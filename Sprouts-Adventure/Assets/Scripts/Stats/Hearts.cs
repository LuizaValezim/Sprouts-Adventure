using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public Health playerHealth;
    public int numberOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update(){

        if (playerHealth.health > numberOfHearts){
            playerHealth.health = numberOfHearts;
        }

        if (playerHealth.health < 0){
            playerHealth.health = 0;
        }

        for (int i = 0; i < hearts.Length; i++){
            
            if(i < playerHealth.health){
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }

            if(i < numberOfHearts){
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }
    }
}
