using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStruct_Town : MonoBehaviour
{
    public Districts Dystrykt;
    string dystrykt;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    GameObject prefab;
    public float generation;
    public MoneyGeneration money;
    public float town1g, town2g, town3g;
    public Powerups_controller cooldown;


    private void OnMouseDown()
    {
        if (money.money >= 1000)
        {
            if (town1g >= 3)
            {
                generation = 2;
            }
            if (town2g >= 5)
            {
                generation = 3;
            }

            if (generation == 1)
            {
                prefab = prefab1;
                
            }
            if (generation == 2)
            {
                prefab = prefab2;
                
            }
            else
            {
                prefab = prefab3;
                
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
            money.money -= 1000f;
        }
    }
    public void Update()
    {

    }
}
