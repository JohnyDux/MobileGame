using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float spawnInterval = 2f;
    public float minX = -5f;
    public float maxX = 5f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            // Spawn a new brick with a random X position within the specified range, and reset the timer
            float randomX = Random.Range(minX, maxX);
            Instantiate(brickPrefab, new Vector2(randomX, transform.position.y), Quaternion.identity);
            timer = 0f;
        }
    }
}