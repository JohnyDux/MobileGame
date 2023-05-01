using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchitectAttack : MonoBehaviour
{
    public int TimesHitPlayer;
    public Animator anim;
    public PlayerMovement player;
    public int Life = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TimesHitPlayer+=1;
            anim.SetBool("Attack", true);
        }

        if (collision.gameObject.CompareTag("Cement"))
        {
            Life -= 10;
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
