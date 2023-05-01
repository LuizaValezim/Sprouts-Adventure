using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect PowerUpEffect;
    public GameObject item;
    private AudioSource source;
    public AudioClip clip;

    public void UsePowerUp()
    {
        PowerUpEffect.Apply(GameObject.FindGameObjectWithTag("Sprout"));
        Destroy(item);
        source = GameObject.FindGameObjectWithTag("Sprout").GetComponent<AudioSource>();
        source.PlayOneShot(clip);
    }
}
