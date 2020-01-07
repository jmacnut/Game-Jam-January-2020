using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   [SerializeField]
   private GameObject _invaderPrefab;

   //[SerializeField]
   //private GameObject _invaderContainer;

   //[SerializeField]
   //private GameObject[] powerups;

   private bool _stopSpawning = false;

   public void StartSpawning()
   {
      StartCoroutine(SpawnInvaderRoutine());
      //StartCoroutine(SpawnPowerupRoutine());
   }

   IEnumerator SpawnInvaderRoutine()
   {
      yield return new WaitForSeconds(3.0f);

      while (_stopSpawning == false)
      {
         float waitTime = 5.0f;

      Vector3 posToSpawn = new Vector3(Random.Range(-9.5f, 9.5f), 10.0f, 0);
      Instantiate(_invaderPrefab, posToSpawn, Quaternion.identity);   // tmp
      //   GameObject newInvader = Instantiate(_invaderPrefab, posToSpawn, Quaternion.identity);
      //   newInvader.transform.parent = _invaderContainer.transform;

      yield return new WaitForSeconds(waitTime);
      }
   }

   //IEnumerator SpawnPowerupRoutine()
   //{
   //   yield return new WaitForSeconds(3.0f);

   //   while (_stopSpawning == false)
   //   {
   //      float waitTime = Random.Range(15.0f, 21.0f);

   //      Vector3 posToSpawn = new Vector3(Random.Range(-9.5f, 9.5f), 10.0f, 0);
   //      int randomPowerUp = Random.Range(0, 3);   // powerups 0, 1, and 2
   //      Instantiate(powerups[randomPowerUp], posToSpawn, Quaternion.identity);

   //      yield return new WaitForSeconds(waitTime);
   //   }
   //}

   //public void OnPlayerDeath()
   //{
   //   _stopSpawning = true;
   //}

}
