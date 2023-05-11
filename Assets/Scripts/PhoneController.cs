using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneController : MonoBehaviour
{
    public RectTransform rt;
    void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rt.anchoredPosition = new Vector2(0, 6.31f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rt.anchoredPosition = new Vector2(0,-6.31f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rt.anchoredPosition = new Vector2(-6.31f, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rt.anchoredPosition = new Vector2(6.31f, 0);
        }
    }
}
