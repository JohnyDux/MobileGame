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
            Cursor.visible = true;
        }
        else
        {
            CrosshairImage.SetActive(true);
            Cursor.visible = false;
        }
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCursorPos;
    }
}
