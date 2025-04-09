using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
public class SpriteNameGetter : MonoBehaviour

{
    //this is from chatgpt hope it works
    public Image image; // Reference to the Image component

    void Start()
    {
        // Access the sprite from the Image component
        Sprite sprite = image.sprite;

        if (sprite != null)
        {
            Debug.Log("Sprite Name: " + sprite.name);
        }
        else
        {
            Debug.LogError("No sprite assigned to the Image.");
        }
    }
   // Valie of card, 2 of clubs = 2, etc
   public int value = 0;

   public int GetValueOfCard()
   {
         return value;
   }

   public void SetValue(int newValue)
   {
        value = newValue;
   }

    public string GetSpriteName()
    {
        return GetComponent<SpriteRenderer>().sprite.name;
    }

    public void SetSprite(Sprite newSprite)
   {
        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
   }

    public void ResetCard()
    {
        Sprite back = GameObject.Find("DeckController").GetComponent<DeckScript>().GetCardBack();
        gameObject.GetComponent<SpriteRenderer>().sprite = back;
        value = 0;
    }


}
