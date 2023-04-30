using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect inv1;
    public PowerUpEffect inv2;
    public PowerUpEffect inv3;
    public PowerUpEffect inv4;

    public void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            inv1.Apply(GameObject.FindGameObjectWithTag("Sprout"));
        }

        if (Input.GetKeyDown("2"))
        {
            inv2.Apply(GameObject.FindGameObjectWithTag("Sprout"));
        }

        if (Input.GetKeyDown("3"))
        {
            inv3.Apply(GameObject.FindGameObjectWithTag("Sprout"));
        }

        if (Input.GetKeyDown("4"))
        {
            inv4.Apply(GameObject.FindGameObjectWithTag("Sprout"));
        }
    }
}
