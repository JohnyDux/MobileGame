using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCement : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;
    public PlayerMovement player;
    public PlayerController controller;

    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }

        if(Input.GetMouseButtonDown(0) && canFire && player.cementCount>0)
        {
            if(controller.m_FacingRight == true)
            {
                canFire = false;
                Instantiate(bullet, bulletTransform.position, transform.rotation);
                player.cementCount = player.cementCount - 3;
            }
            if (controller.m_FacingRight == false)
            {
                canFire = false;
                Instantiate(bullet,bulletTransform.position, transform.rotation);
                player.cementCount = player.cementCount - 3;
            }
        }
    }
}
