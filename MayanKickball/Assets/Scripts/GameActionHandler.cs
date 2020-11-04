using System;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction actionObj;
    public UnityEvent handlerEvent;

    private void Start()
    {
        actionObj.action += Handle;
    }

    private void Handle()
    {
        handlerEvent.Invoke();
    }
}