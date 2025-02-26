using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public TextMeshProUGUI waveText;
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private GameManager gameManager;

    float spawnRange = 9f;

    public int enemyCount;
    int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        SpawnEnemyWave(waveNumber);
        SpawnPowerup();

        waveNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if (enemyCount == 0 && gameManager.isGameActive)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPowerup();
        }
        waveText.text = "Wave: " + waveNumber;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    void SpawnPowerup()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }

    Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
