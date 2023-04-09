using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintValuesOnScreen : MonoBehaviour
{
    public TextMeshProUGUI BrickNum;
    PlayerMovement playerNumBricks;

    void Start()
    {
        playerNumBricks = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        BrickNum.text = playerNumBricks.brickCount.ToString() + "x";
    }
}
