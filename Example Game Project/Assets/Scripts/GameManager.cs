using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Game Buttons
    public Button dealBtn;
    public Button hitBtn;
    public Button standBtn;
    public Button betBtn;

    // Access the player and dealer's script
    PlayerScript playerScript;
    PlayerScript dealerScript;
    void Start()
    {
        // Add on click listeners to the buttons
        dealBtn.onClick.AddListener(() => DealClicked());
        hitBtn.onClick.AddListener(() => HitClicked());
        standBtn.onClick.AddListener(() => StandClicked());
    }

     private void DealClicked()
    {
        playerScript.StartHand();
    }


     private void HitClicked()
    {
        throw new NotImplementedException();
    }


       private void StandClicked()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

