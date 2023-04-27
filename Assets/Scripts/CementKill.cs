using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CementKill : MonoBehaviour
{
    public GameObject CementSpawn;
    Vector2 SpawnHere;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cement")
        {
            SpawnHere = new Vector2(collision.transform.position.x, collision.transform.position.y);
            Instantiate(CementSpawn, SpawnHere, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}
