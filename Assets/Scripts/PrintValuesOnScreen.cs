using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrintValuesOnScreen : MonoBehaviour
{
    public TextMeshProUGUI BrickNum;
    public Slider CementNum;
    PlayerMovement player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        BrickNum.text = player.brickCount.ToString() + "x";
        CementNum.value = player.cementCount;
    }
}
