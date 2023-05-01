using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect PowerUpEffect;
    public GameObject item;

    public void UsePowerUp()
    {
        PowerUpEffect.Apply(GameObject.FindGameObjectWithTag("Sprout"));
        Debug.Log("apple");
        Destroy(item);
    }
}
