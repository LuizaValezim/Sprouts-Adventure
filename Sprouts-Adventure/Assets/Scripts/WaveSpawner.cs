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
    public float spawnInterval;
}

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    public TextMeshProUGUI countText;

    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;

    
    private bool canSpawn = true;

    private void Update()
    {
        currentWave = waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        countText.text = currentWave.numberOfEnemies + "/" + totalEnemies.Length;
        if (totalEnemies.Length == 0 && !canSpawn && currentWaveNumber+1 != waves.Length)
        {
            SpawnNextWave();
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

    void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }
}