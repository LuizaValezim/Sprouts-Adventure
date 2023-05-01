using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Sprout").GetComponent<Inventory>();
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("Sprout")){
            for (int i = 0; i < inventory.slots.Length; i++){
                if (inventory.isFull[i] == false){

                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;

                }
        }
    }

        }
        
}
