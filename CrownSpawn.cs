using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrownSpawn : MonoBehaviour
{
    public GameObject enemy;
    public float minimumSpawnTime;
    public float maximumSpawnTime;
    public float timeUntilSpawn;

    void Awake()
    {
        SetTimeUntilSpawn();
    }

    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;

        if (timeUntilSpawn <= 0)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    public void SetTimeUntilSpawn()
    {
        timeUntilSpawn = Random.Range(minimumSpawnTime, maximumSpawnTime);
    }
}
