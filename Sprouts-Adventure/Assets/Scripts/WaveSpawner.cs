using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference video: https://www.youtube.com/watch?v=pKN8jVnSKyM&ab_channel=ChronoABI

[System.Serializable]

public class Wave 
{
    public string waveName;
    public int numberOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    private bool canSpawn = true;

    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (totalEnemies.Length == 0 && !canSpawn)
        {
            currentWaveNumber++;
            canSpawn = true;
        }
    }

    void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time) 
        { 
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.numberOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;
            if(currentWave.numberOfEnemies == 0) 
            {
                canSpawn = false;
            }
        }
    }
}