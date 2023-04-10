using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLineTrigger : MonoBehaviour
{
    public GameObject WinCanvas;
    void Start()
    {
        WinCanvas.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Brick" )
        {
            WinCanvas.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
