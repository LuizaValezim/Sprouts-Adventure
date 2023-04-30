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
        this.title.text = "Sprout (You)";
        this.description.text = "Sprout just moved from a big city to his family's old farm. He doesn't understand very well what's happenning, but he knows that his mission is to protect his new home from the ones who threaten his family's legacy.";

    }

    public void SetCow(){
        this.title.text = "Betina (Cow)";
        this.description.text = "Betina is your friend, you can always count on her to spend some time with. She doesn't speak much, but that's probably because she is a cow.";

    }

    public void SetMachado(){
        this.title.text = "Milk (PowerUp)";
        this.description.text = "The PowerUp of the Milk ";

    }

    public void SetEnchada(){
        this.title.text = "Grass (PowerUp)";
        this.description.text = "Super Enchada";

    }

    public void SetMaca(){
        this.title.text = "Apple (PowerUp)";
        this.description.text = "Super Maçã";

    }

    public void SetMorangos(){
        this.title.text = "Strawberry (PowerUp)";
        this.description.text = "Super Morangos";

    }

    public void SetUva(){
        this.title.text = "Grapes (PoweUp)";
        this.description.text = "Super Uvas";

    }

    public void SetBlueberry(){
        this.title.text = "Blueberry (PowerUp)";
        this.description.text = "Super Blueberries";

    }


}
