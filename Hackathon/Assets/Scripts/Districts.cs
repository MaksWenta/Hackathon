using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Districts : MonoBehaviour
{
    public CameraMovement pozycje;
    int posx, posy;
    public string District;
   
    public void Update()
    {
        posx = pozycje.PosX;
        posy = pozycje.PosY;



        if (posx == 0 && posy == 0) {
            District = "Aetheria"; }
        else if (posx == 1 && posy == 0)
        {
            District = "Neoventus";

        }
        else if (posx == 1 && posy == 1)
        {
            District = "Zenithia";

        }
        else if (posx == 0 && posy == 1)
        {
            District = "Astra Prime";
        }
        else if (posx == -1 && posy == 0)
        {
            District = "Stellara";
        }
        else if (posx == 0 && posy == -1)
        {
            District = "Cybersphere";
        }
        else if (posx == -1 && posy == -1)
        {
            District = "Quantumville";
        }
        else if (posx == -1 && posy == 1)
        {
            District = "Oktavia";
        }
        else if (posx == 1 && posy == -1)
        {
            District = "Lunaris";
        }

    }
}
    