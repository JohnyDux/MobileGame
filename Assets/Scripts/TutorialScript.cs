using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject canvas;
    public bool CanvasActive;
    void Start()
    {
        canvas.SetActive(true);
        CanvasActive = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            canvas.SetActive(false);
            CanvasActive = false;
            Time.timeScale = 1f;
        }

        if(CanvasActive == true)
        {
            Time.timeScale = 0f;
        }
    }
}
