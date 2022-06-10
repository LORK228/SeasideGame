using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBooster : MonoBehaviour
{
    public GameObject boost;
    private GameObject spawnBoost;
    private Transform camera;
    private spawner spawner;
    private int count;
    // Update is called once per frame
    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        spawner = GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 7)
        {
            collision.gameObject.GetComponent<PlayerController>()._speed += 0.5f;
            spawner.Spawn(boost);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (Mathf.Abs(camera.position.x - transform.position.x) > 10 || Mathf.Abs(camera.position.y - transform.position.y) > 6)
        {
            spawner.Spawn(boost);
            Destroy(gameObject);
        }
    }
}
