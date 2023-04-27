using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeItem : MonoBehaviour
{
    [SerializeField] private AudioMixer MyMixer;
    public float startingVolume = 15;
    public float currentVolume;
    public float mixerVolume;
   
    void Start(){
        currentVolume = startingVolume;
        mixerVolume = currentVolume/15;
        MyMixer.SetFloat("Music", Mathf.Log10(mixerVolume)*20);
    }

    public void SetMinus(){
        currentVolume -= 1;
        if (currentVolume == 0){
            MyMixer.SetFloat("Music", -80.0f);
        } else {
            mixerVolume = currentVolume/15;
            MyMixer.SetFloat("Music", Mathf.Log10(mixerVolume)*20);
        }
    }

    public void SetPlus(){
        currentVolume += 1;
        if (currentVolume == 0){
            MyMixer.SetFloat("Music", -80.0f);
        } else {
            mixerVolume = currentVolume/15;
            MyMixer.SetFloat("Music", Mathf.Log10(mixerVolume)*20);
        }
    }

        
    
}
