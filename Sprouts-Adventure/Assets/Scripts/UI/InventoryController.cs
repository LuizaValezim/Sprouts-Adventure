using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{

    [SerializeField] private Inventory inventory;
    public int inventorySize = 10;

    private void Start(){
        inventory.InitializeInventory(inventorySize);
    }
    
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)){
            if (inventory.isActiveAndEnabled == false){
                inventory.Show();
            } else {
                inventory.Hide();
            }
        }
        
    }
}
