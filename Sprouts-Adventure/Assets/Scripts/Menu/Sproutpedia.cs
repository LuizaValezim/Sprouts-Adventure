using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sproutpedia : MonoBehaviour
{
    [SerializeField] private ItemDescription itemdescription;

    private void Awake(){
        Hide();
        itemdescription.ResetDescription();
    }

    public void Show(){
        gameObject.SetActive(true);
        itemdescription.ResetDescription();
    }

    public void Hide(){
        gameObject.SetActive(false);
    }
}