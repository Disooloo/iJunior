using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;


    private void Start()
    {
       SpawnElements(_template, _spawnPoints);
    }

    private void SpawnElements(GameObject template, Transform[] spawnPoint)
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            Instantiate(template, spawnPoint[i].position, Quaternion.identity);
        }
    }
}