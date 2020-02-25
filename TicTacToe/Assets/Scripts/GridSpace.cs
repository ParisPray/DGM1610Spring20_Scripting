using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    private GameController gameController;
    
        // makes it so that when you click on a button it deactivates into a visual of your move, calls the function to establish your "side", and ends your turn.
    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }

    // Associates controller with all buttons
    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }
  
}
