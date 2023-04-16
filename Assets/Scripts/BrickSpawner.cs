using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject brickPrefab;
    public GameObject cementPrefab;
    public float BrickSpawnInterval = 2f;
    public float CementSpawnInterval = 5f;
    public float minX = -5f;
    public float maxX = 5f;

    private float BrickTimer = 0f;
    private float CementTimer = 0f;

    void Update()
    {
        BrickTimer += Time.deltaTime;
        CementTimer += Time.deltaTime;

        if (BrickTimer >= BrickSpawnInterval)
        {
            // Spawn a new brick with a random X position within the specified range, and reset the timer
            float randomX = Random.Range(minX, maxX);
            Instantiate(brickPrefab, new Vector2(randomX, transform.position.y), Quaternion.identity);
            BrickTimer = 0f;
        }

        if (CementTimer >= CementSpawnInterval)
        {
            // Spawn a new brick with a random X position within the specified range, and reset the timer
            float randomX = Random.Range(minX, maxX);
            Instantiate(cementPrefab, new Vector2(randomX, transform.position.y), Quaternion.identity);
            CementTimer = 0f;
        }
    }
}