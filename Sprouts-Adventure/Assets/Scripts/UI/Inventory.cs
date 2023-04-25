using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryItem itemPrefab;

    [SerializeField] private RectTransform contentPanel;

    List<InventoryItem> listOfItems = new List<InventoryItem>();

    public void InitializeInventory(int inventorySize){

        for (int i = 0; i< inventorySize; i++){
            InventoryItem item = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            item.transform.SetParent(contentPanel);
            listOfItems.Add(item);
        }
    }

    public void Show(){
        gameObject.SetActive(true);
    }

    public void Hide(){
        gameObject.SetActive(false);
    }
}
