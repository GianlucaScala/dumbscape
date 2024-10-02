using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject npcPrefab;
    public Transform[] spawnPoints;

    void Start()
    {
        SpawnNPCs();
    }

    private void SpawnNPCs()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            Instantiate(npcPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}