using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CementKill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Cement(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }
}
