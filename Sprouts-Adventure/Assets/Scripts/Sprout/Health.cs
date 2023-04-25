using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int startingHealth = 3;
    public int currentHealth;
    // Start is called before the first frame Damage
    void Start()
    {
        currentHealth = startingHealth;
        
    }

    // Update is called once per frame
    void Damage(int _damage)
    {
        currentHealth -= currentHealth - _damage;

        if (currentHealth > 0){
            //player hurt
        } else {
            //player dead
        }
        
    }

    private void Update(){

    }
}
