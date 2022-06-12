using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Callib : MonoBehaviour
{
    public GameObject Water;
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Water.transform.position.z - 1);
    }


}
