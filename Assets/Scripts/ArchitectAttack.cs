using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArchitectAttack : MonoBehaviour
{
    public int TimesHitPlayer;
    public Animator anim;
    public PlayerMovement player;
    [Range(0f, 100f)] public float Life = 100;
    public Image LifeSlider;

    private void Update()
    {
        LifeSlider.fillAmount = Life/100;
        if(Life <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TimesHitPlayer+=1;
            anim.SetBool("Attack", true);
        }

        if (collision.gameObject.CompareTag("Cement_Shots"))
        {
            Life -= 40;
            Destroy(collision.gameObject);
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
