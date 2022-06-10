using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBooster : MonoBehaviour
{
    public GameObject boost;
    private GameObject spawnBoost;
    private Transform camera;
    // Update is called once per frame
    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        if (collision.gameObject.layer == 7)
        {
            spawnBoost = Instantiate(boost);
            spawnBoost.name = "Boost";
            collision.gameObject.GetComponent<PlayerController>()._speed += 1;
            spawnBoost.transform.position = new Vector3(camera.position.x+Random.Range(-9, 10),camera.position.y+Random.Range(-4, 5), 0);
            Destroy(gameObject);
        }
    }
}
