using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXIcons : MonoBehaviour
{
    
    public SFXManager sfxVolume;

    public Image[] volume;
    public Sprite fullVolume;
    public Sprite emptyVolume;

    void Update(){

        if (sfxVolume.currentVolume > sfxVolume.startingVolume){
            sfxVolume.currentVolume = sfxVolume.startingVolume;
        }

        if (sfxVolume.currentVolume < 0){
            sfxVolume.currentVolume = 0;
        }

        for (int i = 0; i < volume.Length; i++){
            
            if(i < sfxVolume.currentVolume){
                volume[i].sprite = fullVolume;
            } else {
                volume[i].sprite = emptyVolume;
            }

            if(i < sfxVolume.startingVolume){
                volume[i].enabled = true;
            } else {
                volume[i].enabled = false;
            }
        }
    }
}
