using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicIcons : MonoBehaviour
{
    
    public MusicManager gameVolume;

    public Image[] volume;
    public Sprite fullVolume;
    public Sprite emptyVolume;

    void Update(){

        if (gameVolume.currentVolume > gameVolume.maxVolume){
            gameVolume.currentVolume = gameVolume.maxVolume;
        }

        if (gameVolume.currentVolume < 0){
            gameVolume.currentVolume = 0;
        }

        for (int i = 0; i < volume.Length; i++){
            
            if(i < gameVolume.currentVolume){
                volume[i].sprite = fullVolume;
            } else {
                volume[i].sprite = emptyVolume;
            }

            if(i < gameVolume.maxVolume){
                volume[i].enabled = true;
            } else {
                volume[i].enabled = false;
            }
        }
    }
}
