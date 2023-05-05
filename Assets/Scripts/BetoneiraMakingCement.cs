using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetoneiraMakingCement : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && player.waterCount > 0 && player.sandCount > 0)
        {
            anim.SetBool("MakeCement", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("MakeCement", false);
        }
    }
}
