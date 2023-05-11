using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firepoint : MonoBehaviour
{
    public SpriteRenderer CrosshairImage;
    public PlayerMovement scriptRef;
    public float maxRadius;
    void Update()
    {
        if (scriptRef.Pause == true)
        {
            CrosshairImage.enabled = false;
            Cursor.visible = true;
        }
        else
        {
            CrosshairImage.enabled = true;
            Cursor.visible = true;
        }
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mouseCursorPos.magnitude > maxRadius)
        {
            mouseCursorPos = mouseCursorPos * maxRadius / mouseCursorPos.magnitude;
        }

    }
}
