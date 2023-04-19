using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCement : MonoBehaviour
{
    PlayerMovement player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void Update()
    {
        if (player.cementCount > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }
    void Shoot()
    {
        player.cementCount = player.cementCount - 10;
    }
}
