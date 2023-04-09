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
    void OnCollisionEnter2D(Collision2D collision)
    {
        Number_Collisions=Number_Collisions+1;

        if (Number_Collisions > 2)
            {
                Destroy(gameObject);
            }

        if(Number_Collisions > 1)
        {
            spriteTexture.sprite = damagedBrick;
        }
    }
}
