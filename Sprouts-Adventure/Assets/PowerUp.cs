using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;

    public void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            powerUpEffect.Apply(GameObject.FindGameObjectWithTag("Sprout"));
        }

        
    }
}
