using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnEnemy : MonoBehaviour
{
    private int storona;
    private int spawnx;
    private int spawny;
    public GameObject enemy;
    private GameObject spawned;
    private spawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

}
