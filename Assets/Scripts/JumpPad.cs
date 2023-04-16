using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float bounce = 20f;
    public Rigidbody2D player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit");
            player.AddForce(Vector2.up * bounce * 100, ForceMode2D.Impulse);
        }
    }
}