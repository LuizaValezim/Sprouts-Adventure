using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Reference video: https://www.youtube.com/watch?v=pKN8jVnSKyM&ab_channel=ChronoABI

[System.Serializable]

public class Wave 
{
    public string waveName;
    public int numberOfEnemies;
    public GameObject[] typeOfEnemies;
    public GameObject[] typeOfItems;
    public float spawnInterval;
}

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPointsEnemies;
    public Transform[] spawnPointsItems;

    public Transform spawnPointBoss;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;
    
    private bool canSpawn = true;

    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] totalItems = GameObject.FindGameObjectsWithTag("Item");
        if (totalEnemies.Length == 0 && !canSpawn && currentWaveNumber+1 != waves.Length)
        {
            SpawnNextWave();
        }
    }

    void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }

    void SpawnWave()
    {
        if (canSpawn && nextSpawnTime < Time.time) 
        { 
            // Chosing random enemies and items based on inputs per wave number
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)];
            GameObject randomItem = currentWave.typeOfItems[Random.Range(0, currentWave.typeOfItems.Length)];

            // Generating random spawn points based on inputs
            Transform randomPointEnemies = spawnPointsEnemies[Random.Range(0, spawnPointsEnemies.Length)];
            Transform randomPointItems = spawnPointsItems[Random.Range(0, spawnPointsItems.Length)];

            // Instantiating the final boss (Lion)
            if (currentWave.numberOfEnemies == 1) 
            {
                Instantiate(randomEnemy, spawnPointBoss.position, Quaternion.identity);
            }
            // Instantiating the random enemy
            else 
            {
                Instantiate(randomEnemy, randomPointEnemies.position, Quaternion.identity);
            }

            Instantiate(randomItem, randomPointItems.position, Quaternion.identity);
            currentWave.numberOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;

            if(currentWave.numberOfEnemies == 0) 
            {
                canSpawn = false;
            }

            
        }
    }
}