using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public Transform[] spawnLocations;
  public GameObject ringPrefab;
  public List<GameObject> rings = new List<GameObject>();
  private void Awake()
  {
    SpawnRing(3);
  }
  private void SpawnRing(int amount)
  {
    for (int i = 0; i < amount; i++)
    {
      int index = Random.Range(0, spawnLocations.Length);
      Debug.LogWarning(spawnLocations[index]);
      rings.Add(Instantiate(ringPrefab, spawnLocations[index].position, Quaternion.identity) as GameObject);
    }
    
  }
  //checks if player is in a circle 
  //-> if yes checks if circle is at z=0 
  //-> if yes = +1 point
}
