using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrintValuesOnScreen : MonoBehaviour
{
    public TextMeshProUGUI BrickNum;
    public Slider CementNum;
    public Slider SandNum;
    public Slider WaterNum;
    PlayerMovement player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        BrickNum.text = player.brickCount.ToString() + "x";
        CementNum.value = player.cementCount;
        SandNum.value = player.sandCount;
        WaterNum.value = player.waterCount;
    }
}
