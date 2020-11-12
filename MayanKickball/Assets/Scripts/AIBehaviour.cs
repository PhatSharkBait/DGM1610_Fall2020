using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIBehaviour : MonoBehaviour
{
   private NavMeshAgent agent;
   public Transform goal;
   public Transform ball;
   private BallHandler _ballHandler;

   private void Start()
   {
      agent = GetComponent<NavMeshAgent>();
      _ballHandler = GetComponent<BallHandler>();
   }

   private void Update()
   {
      if (!_ballHandler.hasBall)
      {
         agent.destination = ball.position;
      }

      if (_ballHandler.hasBall)
      {
         agent.destination = goal.position;
      }
   }
}
