using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/DamageBuff")]

public class DamageBuff : PowerUpEffect
{
    public int amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<Shooting>().damage += amount;
    }
}