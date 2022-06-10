using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player2D;
    bool player_dead;
    private Rigidbody2D rb;
    public float _speed;
    public float Rotate_speed;
    float rotateAmount;
    Vector2 direction;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }
    void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 Worldpos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 Worldpos2D = new Vector2(Worldpos.x, Worldpos.y);

        
        direction = Worldpos2D - (Vector2)transform.position;
        direction.Normalize();
        rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = -Rotate_speed * rotateAmount;
        rb.velocity = transform.up * _speed;

    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.layer)
        {
            case 6:
                Destroy(gameObject);
                break;
            case 8:
                print(1);
                break;
        }
            
    }
}
