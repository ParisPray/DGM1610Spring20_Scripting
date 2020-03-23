using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnumsSwitches : MonoBehaviour
{
    public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
    public UnityEvent startingEvent, playingEvent, inStoreEvent, pausingEvent, endingEvent;
    public enum GameStates
    {
        Starting,
        Playing,
        InStore,
        Pausing,
        Ending
    }

    public GameStates currentGameState;
    public enum PlayerStates
    {
        Idle,
        Walk,
        Run,
        Jump
    }

    public PlayerStates currentPlayerState;

    public void Update()
    {
        switch (currentPlayerState)
        {
            case PlayerStates.Idle:
                idleEvent.Invoke;
                break;
            case PlayerStates.Walk:
               walkEvent.Invoke;
                break;
            case PlayerStates.Run:
                runEvent.Invoke;
                break;
            case PlayerStates.Jump:
                jumpEvent.Invoke;
                break;
          
        }

    }
}
