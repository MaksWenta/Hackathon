using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup2x : MonoBehaviour
{
    public Powerups_controller controller;
    public GameObject myself;

    void OnMouseDown()
    {
        controller.incomex2(5);
        Destroy(myself);
    }
}
