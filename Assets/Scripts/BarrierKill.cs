using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierKill : MonoBehaviour
{
    public double Number_Collisions;
    SpriteRenderer spriteTexture;
    public Sprite brick,damagedBrick;
    private void Start()
    {
        spriteTexture = GetComponent<SpriteRenderer>();
        spriteTexture.sprite = brick;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Number_Collisions = Number_Collisions + 1;

            if (Number_Collisions > 4)
            {
                Destroy(gameObject);
            }

            if (Number_Collisions > 2)
            {
                spriteTexture.sprite = damagedBrick;
            }
        }
    }
}
