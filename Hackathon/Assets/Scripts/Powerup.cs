using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Powerups_controller controller;
    public int time, multiplier;

    public void OnMouseDown()
    {
        controller.Get_the_fuck_out(multiplier);
        
    }
}
