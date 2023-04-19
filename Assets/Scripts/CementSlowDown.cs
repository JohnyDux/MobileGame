using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CementSlowDown : MonoBehaviour
{
    PlayerMovement player;
    private void Start()
    {
        player.GetComponent<PlayerMovement>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.runSpeed = 10f;
        }
    }
}
