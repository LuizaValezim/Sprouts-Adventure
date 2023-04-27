using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SFXManager : MonoBehaviour
{
    [SerializeField] private AudioMixer MyMixer;
    public float maxVolume = 15;
    public float currentVolume;
    public float mixerVolume;

    void Start(){
        currentVolume = 8;
        mixerVolume = currentVolume/15;
        MyMixer.SetFloat("SFX", Mathf.Log10(mixerVolume)*20);
    }

    public void SetMinus(){
        currentVolume -= 1;
        if (currentVolume == 0){
            MyMixer.SetFloat("SFX", -80.0f);
        } else {
            mixerVolume = currentVolume/15;
            MyMixer.SetFloat("SFX", Mathf.Log10(mixerVolume)*20);
        }
    }

    public void SetPlus(){
        currentVolume += 1;
        if (currentVolume == 0){
            MyMixer.SetFloat("SFX", -80.0f);
        } else {
            mixerVolume = currentVolume/15;
            MyMixer.SetFloat("SFX", Mathf.Log10(mixerVolume)*20);
        }
    }

    
}
