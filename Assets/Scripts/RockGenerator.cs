using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    public GameObject rock;
    float spawnTimer;
    float spawnRate = 0.3f;

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnRate)
        {
            spawnTimer -= spawnRate;
            Vector2 spawnPosition = new Vector2(Random.Range(0.5393648f, 26.42f), -18.13f);
            Instantiate(rock, spawnPosition, Quaternion.identity);
        }
    }
}
