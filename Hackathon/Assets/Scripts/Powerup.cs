using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Powerups_controller controller;
    public int time, multiplier;

    void OnMouseDown()
    {
        controller.income_boost(time, multiplier);
    }
}
