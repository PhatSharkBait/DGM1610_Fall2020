using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   public GameObject[] animalPrefabs;
   private float spawnRange = 15f;
   private float spawnPosZ = 30f;
   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.S))
      {
         int animalIndex = Random.Range(0, animalPrefabs.Length);
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
         Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
      }
   }
}
