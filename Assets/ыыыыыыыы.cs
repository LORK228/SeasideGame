using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ыыыыыыыы : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boost;
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawner>().Spawn(boost);
        }
    }
}
