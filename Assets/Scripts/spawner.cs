using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private int storona;
    private float spawnx;
    private float spawny;
    public Transform camera;
    private GameObject spawned;
    public void Spawn(GameObject obj)
    {
        storona = Random.Range(1, 5);
        switch (storona)
        {
            case 1:
                spawny = camera.transform.position.y+6;
                spawnx = camera.transform.position.x + Random.Range(-10, 11);
                break;

            case 2:
                spawny = camera.transform.position.y + Random.Range(-5, 6); ;
                spawnx = camera.transform.position.x -10;
                break;
            case 3:
                spawny = camera.transform.position.y-6;
                spawnx = camera.transform.position.x + Random.Range(-10, 11);
                break;
            case 4:
                spawny = camera.transform.position.y + Random.Range(-5, 6); ;
                spawnx = camera.transform.position.x + 10;
                break;
        }
        print(spawnx + " " + spawny);
        spawned = Instantiate(obj);
        spawned.name = "";
        spawned.transform.position = new Vector3(spawnx, spawny, 0);
    }
}
