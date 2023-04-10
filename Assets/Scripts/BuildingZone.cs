using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingZone : MonoBehaviour
{
    public int bricksPerRow = 5;
    public float brickSpacing = 1f;
    public BoxCollider2D brickPrefab;

    public int bricksInZone = 0;

    PlayerMovement script_ref;

    void Start()
    {
        script_ref = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        brickPrefab.isTrigger = false;

        if (other.gameObject.CompareTag("Player"))
        {
            // Calculate the number of rows and columns needed to place all the bricks
            int numRows = Mathf.CeilToInt((float)bricksInZone / bricksPerRow);
            int numCols = Mathf.Min(bricksInZone, bricksPerRow);

            // Calculate the starting position for the first brick
            float startX = transform.position.x - ((numCols - 1) * brickSpacing * 0.5f);
            float startY = transform.position.y + ((numRows - 1) * brickSpacing * 0.5f);
            Vector2 currentPos = new Vector2(startX, startY+50);

            // Instantiate the bricks and place them side by side
            for (int i = 0; i < script_ref.brickCount; i++)
            {
                Instantiate(brickPrefab, currentPos, Quaternion.identity);
                currentPos.x += brickSpacing;

                if ((i + 1) % bricksPerRow == 0)
                {
                    currentPos.x = startX;
                    currentPos.y -= brickSpacing;
                }
            }

            brickPrefab.gameObject.layer = 3;

            // Reset the brick count for the next building zone
            bricksInZone = 0;

            script_ref.brickCount = 0;
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Update the brick count when the player leaves the building zone
            PlayerMovement playerController = other.gameObject.GetComponent<PlayerMovement>();
            if (playerController != null)
            {
                bricksInZone = playerController.brickCount;
            }
        }
    }
}
