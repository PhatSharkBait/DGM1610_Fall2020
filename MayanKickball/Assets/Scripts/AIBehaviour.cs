using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIBehaviour : MonoBehaviour
{
   private NavMeshAgent _agent;
   public Transform goal;
   public GameObject ball;
   private BallHandler _ballHandler;

   private void Start()
   {
      ball = gameObject.GetComponent<BallHandler>().currentBall;
      _agent = GetComponent<NavMeshAgent>();
      _ballHandler = GetComponent<BallHandler>();
   }
   public void ChangeBall()
   {
      ball = _ballHandler.currentBall;
   }

   private void Update()
   {
      if (!_ballHandler.hasBall)
      {
         _agent.destination = ball.transform.position;
      }

      if (_ballHandler.hasBall)
      {
         _agent.destination = goal.position;
      }
   }
}
