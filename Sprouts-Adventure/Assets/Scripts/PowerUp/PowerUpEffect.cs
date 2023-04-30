using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PowerUpEffect : ScriptableObject
{
    public abstract void Apply(GameObject target);
}
