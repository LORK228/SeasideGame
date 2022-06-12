using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private Material[] m_arr_material;
    public float speed;
    private float timer;
    void Start()
    {
        timer = 0;
        m_arr_material = GetComponent<Renderer>().materials; 
    }

    private void Update()
    {
        m_arr_material[1].mainTextureOffset = new Vector2(1, timer);
        timer -= speed;
    }
}
