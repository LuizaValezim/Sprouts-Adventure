using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public int damage;

    public void OnCollisionEnter2D(Collision2D collision)  
    {
        // Have effect when bullet hits something
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 2f);

        // Enemies to take damage
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent)) 
        {
            enemyComponent.Damage(damage);
        }

        // Destroying the bullet
        Destroy(gameObject, 2f);
    }

    public void SetDamage(int amount) 
    {
        damage = amount;
    }
}
