using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float milisecond;
    public static float second;
    private void Start()
    {
        second = 0;
    }
    private void FixedUpdate()
    {
        milisecond += 1 / _speed;
        if(milisecond >= 1)
        {
            second += 1;
            milisecond = 0;
        }
    }
}
