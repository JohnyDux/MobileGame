using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Faucet : MonoBehaviour
{
    public int waterIncrement;

    public Animator animator;

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            animator.SetBool("GiveWater", false);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
            animator.SetBool("GiveWater", true);
    }
}
