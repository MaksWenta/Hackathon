using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStruct_Fab : MonoBehaviour
{
    public Districts Dystrykt;
    string dystrykt;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    GameObject prefab;
    public float generation;
    public MoneyGeneration money;
    

    private void OnMouseDown()
    {
        if (money.money >= 500)
        {
            if (money.fabGene1 >= 20)
            {
                generation = 2;
            }
            if (money.fabGene2 >= 20)
            {
                generation = 3;
            }

            if (generation == 1)
            {
                prefab = prefab1;
                money.fabGene1++;
            }
            else if (generation == 2)
            {
                prefab = prefab2;
                money.fabGene2++;
            }
            else if (generation == 3)
            {
                prefab = prefab3;
                money.fabGene3++;
            }

            dystrykt = Dystrykt.District;

            if (dystrykt == "Aetheria")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-2f, 2f), Random.Range(-1f, 1f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Neoventus")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(2f, 4f), Random.Range(-1f, 1f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Zenithia")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(2f, 6f), Random.Range(1f, 3f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Astra Prime")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-2f, 2f), Random.Range(1f, 3f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Stellara")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-6f, -2f), Random.Range(-1f, 1f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Cybersphere")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-2f, 2f), Random.Range(-1f, -3f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Quantumville")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-6.30f, -2.30f), Random.Range(-1f, -3f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Oktavia")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-6.30f, -2.30f), Random.Range(1f, 3f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            else if (dystrykt == "Lunaris")
            {
                Vector2 spawnPosition = new Vector2(Random.Range(2f, 6f), Random.Range(-1f, -3f));
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
            money.money -= 500f;
        }
        }
    public void Update()
    {
        
    }
}
