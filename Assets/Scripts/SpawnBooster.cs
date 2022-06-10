using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBooster : MonoBehaviour
{
    public GameObject boost;
    private GameObject spawnBoost;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        if (collision.gameObject.layer == 7)
        {
            spawnBoost = Instantiate(boost);
            spawnBoost.name = "Boost";
            spawnBoost.transform.position = new Vector3(Random.Range(-9, 10), Random.Range(-4, 5), 0);
            Destroy(gameObject);
        }
    }
}
