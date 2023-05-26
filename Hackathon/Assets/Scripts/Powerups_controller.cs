using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups_controller : MonoBehaviour
{
    float income_booster = 1f;
    int waiting_powerups = 0;
    public GameObject x2, x3, x5, small_price;

    IEnumerator boost(float time, float multiplier)
    {
        income_booster *= multiplier;
        waiting_powerups--;

        yield return new WaitForSeconds(time);

        if (multiplier == 2)
        {
            x2.transform.position = new Vector3(50000, 5000000, 0);
        }
        else if (multiplier == 3)
        {
            x3.transform.position = new Vector3(50000, 5000000, 0);
        }
        else if (multiplier == 5)
        {
            x5.transform.position = new Vector3(50000, 5000000, 0);
        }

        

        income_booster /= multiplier;

    }
    
    void spawn(int to_spawn)
    {
        if (to_spawn == 0)
        {
            x2.transform.position = new Vector3(2, (float)0.6 - (float)waiting_powerups * (float)0.5, 0);
        }
        else if (to_spawn == 1)
        {
            x3.transform.position = new Vector3(2, (float)0.6 - (float)waiting_powerups * (float)0.5, 0);
        }
        else if (to_spawn == 2)
        {
            x5.transform.position = new Vector3(2, (float)0.6 - (float)waiting_powerups * (float)0.5, 0);
        }
        waiting_powerups++;
    }

    IEnumerator spawn_powerups()
    {
        yield return new WaitForSeconds(5);

        int to_spawn = Random.Range(0, 3);
        if (to_spawn == 0 && x2.transform.position.y > 5000)
        {
            spawn(to_spawn);
        }
        else if (to_spawn == 1 && x3.transform.position.y > 5000)
        {
            spawn(to_spawn);
        }
        else if (to_spawn == 2 && x5.transform.position.y > 5000)
        {
            spawn(to_spawn);
        }

        StartCoroutine(spawn_powerups());
    }

    public void income_boost(float time, float multiplier)
    {
        StartCoroutine(boost(time, multiplier));
    }

    public void Start()
    {
        StartCoroutine(spawn_powerups());
    }
}
