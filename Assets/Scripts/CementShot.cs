using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CementShot : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public PlayerController player;
    public bool FacingRight;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        FacingRight = player.m_FacingRight;
        if (FacingRight == true)
        {
            speed = speed * 1;
        }
        if (FacingRight == false)
        {
            speed = -speed * 1;
        }
    }
}
