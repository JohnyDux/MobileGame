using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject sandPrefab;
    public float SandSpawnInterval = 5f;
    public float minX = -5f;
    public float maxX = 5f;

    private float SandTimer = 0f;

    void Update()
    {
        SandTimer += Time.deltaTime;

        if (SandTimer >= SandSpawnInterval)
        {
            // Spawn a new brick with a random X position within the specified range, and reset the timer
            float randomX = Random.Range(minX, maxX);
            Instantiate(sandPrefab, new Vector2(randomX, transform.position.y), Quaternion.identity);
            SandTimer = 0f;
        }
    }
}