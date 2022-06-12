using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
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


    void FixedUpdate()
    {

        direction = player.transform.position - transform.position;
        direction.Normalize();
        rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = Rotate_speed * rotateAmount;
        rb.velocity = -transform.up * _speed;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z - 90, transform.rotation.w);
        }
    }
}
