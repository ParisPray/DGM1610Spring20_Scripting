using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text[] buttonList;

// FOR MY PROFESSOR IF HES READING THIS: hi!!! :D

    // Function for looping through all the buttons
    void SetGameControllerReferenceOnButtons()
    {
        for(int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }

    private void Awake()
    {
        SetGameControllerReferenceOnButtons();
    }

    // assigns a symbol to a player side

    public string GetPlayerSide()
    {
        return "?";
    }

    // future site of the "ending your turn" function.
    public void EndTurn()
    {
        Debug.Log("EndTurn is not implemented!");
    }
}
