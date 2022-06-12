using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachSpawner : MonoBehaviour
{
    public GameObject[] trash; 
    public int trashcount;
    private void Start()
    {
        spawn();
    }
    private void spawn()
    {
        for (int i = 0; i < trashcount; i++)
        {
            GameObject spawn = Instantiate(trash[Random.Range(0, trash.Length)]);
            spawn.transform.position = new Vector2(Random.Range(-65, 65), Random.Range(-2.2f, -4f));
             
        }
    }
}
 