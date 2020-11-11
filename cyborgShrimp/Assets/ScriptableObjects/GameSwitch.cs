using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameSwitch : ScriptableObject
{
    public enum GameStates
    {
        Starting,
        Playing,
        Ending,
        InStore,
        Pausing
    }

    public GameStates currentGameState = GameStates.Starting;

    public void ChangeToPlaying()
    {
        currentGameState = GameStates.Playing;
    }

    public void RunCurrentState()
    {
        switch (currentGameState)
        {
            case GameStates.Starting:
                Debug.Log("starting");
                break;
            case GameStates.Playing:
                Debug.Log("playing");
                break;
            case GameStates.Ending:
                Debug.Log("ending");
                break;
            case GameStates.InStore:
                Debug.Log("in Store");
                break;
            case GameStates.Pausing:
                Debug.Log("pausing");
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
    
}
