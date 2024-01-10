using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnKnife : MonoBehaviour
{
     public Transform SpawnPos;
     public GameObject enemy;
     public int TimeSpawn = 3;

    void Start()
    { 
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(enemy, SpawnPos.position, Quaternion.identity); 
        Repeat();
    }
    
}


