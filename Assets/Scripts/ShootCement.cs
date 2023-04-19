using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCement : MonoBehaviour
{

    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed = 50;

    PlayerMovement player;
    PlayerController facingRight;

    public Vector2 lookDirection;
    float lookAngle;

    GameObject bulletClone;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        facingRight = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);

        if (Input.GetMouseButtonDown(0) && facingRight.m_FacingRight && player.cementCount > 0)
        {
            bulletClone = Instantiate(bullet);
            bulletClone.transform.position = firePoint.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletSpeed;

            player.cementCount = player.cementCount - 10;
        }

        if (Input.GetMouseButtonDown(0) && !facingRight.m_FacingRight && player.cementCount > 0)
        {
            bulletClone = Instantiate(bullet);
            bulletClone.transform.position = firePoint.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = -firePoint.right * bulletSpeed;

            player.cementCount = player.cementCount - 10;
        }
    }
}
