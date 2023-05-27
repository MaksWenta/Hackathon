using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyGeneration : MonoBehaviour
{
    public float fabGene1;
    public float fabGene2;
    public float fabGene3;
    public float money;
    public Powerups_controller gowno;
    const float g1m = 1f, g2m = 1.5f, g3m = 2f, fabinc = 5f;
    IEnumerator piniandz()
    {
    
        yield return new WaitForSeconds(1);
        money += (fabGene1 * fabinc * g1m + fabGene2 * fabinc * g2m + fabGene3 * fabinc * g3m) * gowno.smiec;

        StartCoroutine(piniandz());
    }

    void Start()
    {
        money += fabGene1 * fabinc * g1m + fabGene2 * fabinc * g2m + fabGene3 * fabinc * g3m;
        StartCoroutine(piniandz());
        
    }

}
