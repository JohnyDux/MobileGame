using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetoneiraMakingCement : MonoBehaviour
{
    public Animator anim;
    public PlayerMovement player;
    float lastWaterCount;
    float lastSandCount;

    private void Start()
    {
        lastWaterCount = 0;
        lastSandCount = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (player.waterCount > 0 && player.sandCount > 0)
                anim.SetBool("MakeCement", true);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (player.waterCount > 0 && player.sandCount > 0)
            {
                player.waterCount = 0;
                player.sandCount = 0;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && player.cementCount <= 100)
        {
            if(player.cementCount + 30f > 100f)
            {
                player.cementCount = 100f;
            }
            else
            {
                player.cementCount = player.cementCount + 30;
            }
            
            anim.SetBool("MakeCement", false);
            lastWaterCount = player.waterCount;
            lastSandCount = player.sandCount;
        }
    }
}
