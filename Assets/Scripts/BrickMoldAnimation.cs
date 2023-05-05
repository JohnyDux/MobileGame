using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMoldAnimation : MonoBehaviour
{
    public Animator animator;
    public PlayerMovement player;

    public void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Build", false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && (player.cementCount > 3))
        {
            animator.SetBool("Build", true);
        }
    }
}
