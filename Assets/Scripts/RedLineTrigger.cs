using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLineTrigger : MonoBehaviour
{
    public Canvas WinCanvas;
    void Start()
    {
        WinCanvas.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Brick" )
        {
            WinCanvas.enabled = true;
            Time.timeScale = 0.0f;
        }
    }
}
