using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLineTrigger : MonoBehaviour
{
    public GameObject WinCanvas;

    public GameObject BrickNum;
    public GameObject BrickImage;
    void Start()
    {
        WinCanvas.SetActive(false);
        Time.timeScale = 1.0f;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Brick" )
        {
            BrickImage.SetActive(false);
            BrickNum.SetActive(false);

            WinCanvas.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
