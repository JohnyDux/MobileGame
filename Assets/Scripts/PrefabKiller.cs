using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabKiller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sand"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Cement_Shots"))
        {
            Destroy(collision.gameObject);
        }
    }
}
