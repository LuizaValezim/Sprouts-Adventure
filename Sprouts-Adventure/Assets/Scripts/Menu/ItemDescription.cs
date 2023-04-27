using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDescription : MonoBehaviour
{
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text description;

    public void Awake(){
        ResetDescription();
    }

    public void ResetDescription(){
        this.title.text = "";
        this.description.text = "";
    }

    public void SetSprout(){
        this.title.text = "Sprout";
        this.description.text = "Super Coelho";

    }

    public void SetCow(){
        this.title.text = "Betina";
        this.description.text = "Super Cow";

    }

    public void SetMachado(){
        this.title.text = "Machado";
        this.description.text = "Super Machado";

    }

    public void SetEnchada(){
        this.title.text = "Enchada";
        this.description.text = "Super Enchada";

    }

    public void SetMaca(){
        this.title.text = "Maçã";
        this.description.text = "Super Maçã";

    }

    public void SetMorangos(){
        this.title.text = "Morangos";
        this.description.text = "Super Morangos";

    }

    public void SetUva(){
        this.title.text = "Uvas";
        this.description.text = "Super Uvas";

    }

    public void SetBlueberry(){
        this.title.text = "Blueberry";
        this.description.text = "Super Blueberries";

    }


}
