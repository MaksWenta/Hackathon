using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStruct : MonoBehaviour
{
    public Districts Dystrykt;
    string dystrykt;
    public GameObject prefab;
    private void OnMouseDown()
    {
       dystrykt = Dystrykt.District;

        if(dystrykt == "Aetheria")
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
            Vector2 spawnPosition = new Vector2(Random.Range(-6f, -2f), Random.Range(-1f, -3f));
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
        else if(dystrykt == "Oktavia")
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-6f, -2f), Random.Range(1f, 3f));
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
        else if(dystrykt == "Lunaris")
        {
            Vector2 spawnPosition = new Vector2(Random.Range(2f, 6f), Random.Range(-1f, -3f));
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
