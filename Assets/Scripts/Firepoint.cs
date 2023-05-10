using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firepoint : MonoBehaviour
{
    public GameObject CrosshairImage;
    public PlayerMovement scriptRef;

    void Update()
    {
        if (scriptRef.Pause == true)
        {
            CrosshairImage.SetActive(false);
        }
        else
        {
            CrosshairImage.SetActive(true);
        }
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCursorPos;
    }
}
