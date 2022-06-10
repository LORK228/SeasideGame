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
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        storona = Random.Range(1, 5);
        switch (storona)
        {
            case 1:
                spawny = 6;
                spawnx = Random.Range(-10, 11);
                break;

            case 2:
                spawny = Random.Range(-5, 6); ;
                spawnx = -10;
                break;
            case 3:
                spawny = -6;
                spawnx = Random.Range(-10, 11);
                break;
            case 4:
                spawny = Random.Range(-5, 6); ;
                spawnx = 10;
                break;
        }
        print(spawnx+" "+spawny);
        spawned = Instantiate(enemy);
        spawned.transform.position = new Vector3(spawnx, spawny, 0);

    }

}
