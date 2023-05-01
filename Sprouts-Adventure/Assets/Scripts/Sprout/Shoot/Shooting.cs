using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int damage;
    private bool shooting = true;
    public float bulletForce = 20f;

    public AudioSource source;
    public AudioClip clip;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
             shooting = false;
             if (Input.GetKeyDown(KeyCode.Escape)){
             shooting = true;
            }
        }
        if (Input.GetButtonDown("Fire1")) 
        {
            if (shooting == true){
                Shoot();
                source.PlayOneShot(clip);
            }
        }
    }

    void Shoot() 
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        bullet.GetComponent<Bullet>().SetDamage(damage);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        // Apply force to the bullet
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}