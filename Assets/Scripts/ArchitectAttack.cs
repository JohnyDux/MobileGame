using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchitectAttack : MonoBehaviour
{
    public int TimesHitPlayer;
    public Animator anim;
    public PlayerMovement player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.brickCount = player.brickCount - 2;
            player.cementCount = player.cementCount - 25;
            player.sandCount = player.sandCount - 25;
            player.waterCount = player.waterCount -25;
            TimesHitPlayer+=1;
            anim.SetBool("Attack", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Attack", false);
        }
    }
}
