using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    public GameObject canvas;
    void Start()
    {
        canvas.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            canvas.SetActive(false);
        }
    }
}
