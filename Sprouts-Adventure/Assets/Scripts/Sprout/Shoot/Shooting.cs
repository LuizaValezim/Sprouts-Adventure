using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int damage;
    private bool shooting = true;
    public float bulletForce = 20f;

    private AudioSource source;
    public AudioClip clip;

    public TextMeshProUGUI damageText;

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
                source = GameObject.FindGameObjectWithTag("Sprout").GetComponent<AudioSource>();
                source.PlayOneShot(clip);
            }
        }

        damageText.text = damage.ToString();
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