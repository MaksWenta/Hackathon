using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups_controller : MonoBehaviour
{
    float income_booster = 1f;

    IEnumerator boost_2x(float time)
    {
        income_booster *= 2;

        yield return new WaitForSeconds(time);

        income_booster /= 2;

    }

    public void incomex2(float time)
    {
        StartCoroutine(boost_2x(5));
    }
}
