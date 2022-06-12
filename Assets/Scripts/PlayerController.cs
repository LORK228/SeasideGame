using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] public  float speedParticle;
    private int bestScore;
    bool player_dead;
    private Rigidbody2D rb;
    public float _speed;
    public float Rotate_speed;
    float rotateAmount;
    Vector2 direction;
    [HideInInspector] public float rad;
    private SpriteRenderer sprite;
    private spawner spawner;
    public GameObject rock;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        spawner = GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawner>();
        rad = Mathf.Infinity;
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
        if (_speed > 0)
        {
            _speed -= 0.002f * _speed;
            GetComponentInChildren<ParticleSystem>().startLifetime -= speedParticle * Time.fixedDeltaTime;
        }
    }
    private void Update()
    {
        if (Time.timeScale != 0)
        {
            text.text = "velocity: " + _speed + " Score: " + Timer.second;
        }
        else if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        switch (collision.gameObject.layer)
        {
            case 6:
                if (Timer.second > PlayerPrefs.GetInt("BestScore", 0))
                {
                    bestScore = (int)Timer.second;
                    PlayerPrefs.SetInt("BestScore", bestScore);
                }
                text.text = "BestScore: " + PlayerPrefs.GetInt("BestScore", 0) + "\n Your Score:" + Timer.second + "\nPress \"R\" to restart";
                
                Time.timeScale = 0;
                break;
            case 0:
                transform.rotation =new Quaternion(transform.rotation.x,transform.rotation.y,- 90,transform.rotation.w);
                break;
        }
    }
}
