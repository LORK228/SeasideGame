using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public PlayerController player;
    public Transform pltr;
    private float fd;
    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, pltr.position)< player.rad)
        {
            player.rad = Vector2.Distance(transform.position, pltr.position);
            print(player.rad);
        }
    }
}
