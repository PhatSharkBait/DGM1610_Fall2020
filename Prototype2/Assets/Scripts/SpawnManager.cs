using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
   public GameObject[] animalPrefabs;
   private float spawnRange = 15f;
   private float spawnPosZ = 30f;

   private float startDelay = 2;
   private float spawnInterval = 1.5f;

   private void Start()
   {
      InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
   }

   private void Update()
   {

   }

   private void SpawnRandomAnimal()
   {
      int animalIndex = Random.Range(0, animalPrefabs.Length);
      Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
         
      Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
   }
}
