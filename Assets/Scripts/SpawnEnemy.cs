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
    private int min;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawner>();
        min = 20;
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer.second == min)
        {
            print("yes");
            spawner.Spawn(enemy);
            min += 20;
        }

    }

}
