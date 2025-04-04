using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
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
        GetSpriteName back = GameObject.Find("DeckController").GetComponent<DeckScript>().GetCardBack();
        gameObject.GetComponent<SpriteRenderer>().sprite = back;
        value = 0;
    }


}
