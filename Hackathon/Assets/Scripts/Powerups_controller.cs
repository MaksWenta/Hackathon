using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups_controller : MonoBehaviour
{
    public GameObject x2, x5, x10;
    public int smiec = 1;

    IEnumerator Czas_trwania(int sekundy, int multi)
    {
        yield return new WaitForSeconds(sekundy);
        smiec /= multi;
    }

    public void Get_the_fuck_out(int multiplier)
    {
        if(multiplier == 2)
        {
            x2.transform.position = new Vector3(50000, 50000, 0);
            smiec *= 2;
            StartCoroutine(Czas_trwania(15, 2));
        }
        else if(multiplier == 5)
        {
            x5.transform.position = new Vector3(50000, 50000, 0);
            smiec *= 5;
            StartCoroutine(Czas_trwania(10, 5));
        }
        else if(multiplier == 10)
        {
            x10.transform.position = new Vector3(50000, 50000, 0);
            smiec *= 10;
            StartCoroutine(Czas_trwania(5, 10));

        }

    }

    float Rand;

    IEnumerator resp()
    {
        Debug.Log("DZIALA");
    
        Rand = Random.Range(0, 3);
        Debug.Log(Rand);
        if (Rand == 0 && x2.transform.position != new Vector3((float)1.8, (float)0.5, 0)) {
            x2.transform.position = new Vector3((float)1.8, (float)0.5, 0);
            if(smiec % 2 == 0)
            {
                smiec /= 2;
            }
        }
        else if (Rand == 1 && x5.transform.position != new Vector3((float)1.8, 0, 0)) {
            x5.transform.position = new Vector3((float)1.8, 0, 0);
            if (smiec % 5 == 0)
            {
                smiec /= 5;
            }
        }
        else if (Rand == 2 && x10.transform.position != new Vector3((float)1.8, (float)-0.5, 0)) {
            x10.transform.position = new Vector3((float)1.8, (float)-0.5, 0);
            if (smiec % 10 == 0)
            {
                smiec /= 10;
            }
        }
        else
        {
            StartCoroutine(resp());
        }
        yield return new WaitForSeconds(5);
        StartCoroutine(resp());
    }

    void Start()
    {
        Debug.Log("DZIALA");
        StartCoroutine(resp());
    }
}
