using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private Rigidbody2D rb;
    public float _speed;
    public float Rotate_speed;
    float rotateAmount;
    Vector2 direction;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = player.transform.position - transform.position;
        direction.Normalize();
        rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = -Rotate_speed * rotateAmount;
        rb.velocity = transform.up * _speed;

    }
}
