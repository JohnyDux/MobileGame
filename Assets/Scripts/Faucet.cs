using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Faucet : MonoBehaviour
{
    public int waterIncrement;

    public void AddWater(int value)
    {
        waterIncrement = +value;
    }
}
