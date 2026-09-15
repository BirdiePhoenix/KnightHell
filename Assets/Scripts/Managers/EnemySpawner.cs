using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private WaveManager waveManager;
    [SerializeField] private Timer timer;
    //[SerializeField] Transform spawnPos;
    [SerializeField] private List<GameObject> enemyTypes = new List<GameObject>();
    [SerializeField] private List<GameObject> spawnPoints = new List<GameObject>();

    private bool canSpawn = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //waveManager = GetComponent<WaveManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer.Seconds % 10 == 3)
        {
            canSpawn = true;
        }
        SpawnEnemy(); // Example: spawn the first enemy type at the spawner's position  
    }

    private void SpawnEnemy()
    {
        //if (enemyTypeIndex < 0 || enemyTypeIndex >= enemyTypes.Count)
        //{
        //    Debug.LogError("Invalid enemy type index: " + enemyTypeIndex);
        //    return;
        //}
        
        if ((timer.Seconds % 10 == 0 || timer.Seconds == 0) && canSpawn) // Spawn enemies every 10 seconds
        {
            int amountToSpawn = waveManager.AmountOfEnemies; // Assuming you have a WaveManager instance to get the amount of enemies to spawn
            int _rndmIndex = GenerateSpawnPoint();
            Debug.Log(_rndmIndex);
            int enemyTypeIndex = GenerateEnemyType();
            Debug.Log(enemyTypeIndex);

            canSpawn = false;
            // Spawn enemies
            for (int i = 0; i < amountToSpawn; i++)
            {
                var enemy = Instantiate(enemyTypes[enemyTypeIndex]);
                enemy.transform.position = spawnPoints[_rndmIndex].transform.position;
            }
        } 
    }

    private int GenerateSpawnPoint()
    {
        int maxSpawnPoints = spawnPoints.Count;
        int rndmIndex = Random.Range(0, maxSpawnPoints);
        return rndmIndex;
    }

    private int GenerateEnemyType()
    {
        int maxEnemyTypes = enemyTypes.Count;
        int rndmIndex = Random.Range(0, maxEnemyTypes);
        return rndmIndex;
    }
}
