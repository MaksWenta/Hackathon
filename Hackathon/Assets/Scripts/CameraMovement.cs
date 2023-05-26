using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public int PosX, PosY;
    // Start is called before the first frame update
    void Start()
    {
        PosX = 0;
        PosY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.LeftArrow) && PosX > -1)
        {
            transform.position += new Vector3(-4, 0, 0);
            PosX--;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow) && PosX < 1)
        {
            transform.position += new Vector3(4, 0, 0);
            PosX++;

        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && PosY < 1)
        {
            transform.position += new Vector3(0, 2, 0);
            PosY++;

        }

        if(Input.GetKeyDown(KeyCode.DownArrow) && PosY > -1)
        {
            transform.position += new Vector3(0, -2, 0);
            PosY--;

        }
    }
}
