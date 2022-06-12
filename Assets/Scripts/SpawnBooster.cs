using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBooster : MonoBehaviour
{
    public float boostParticle;
    private GameObject spawnBoost;
    private Transform camera;
    private spawner spawner;
    private int count;
    public AudioClip audioclip;
    public bool used;
    public GameObject booster;
    private void Start()
    {
        used = false;
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        spawner = GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawner>();
        if (GetComponent<BoxCollider2D>() == false)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 7 && used == false)
        {
            
            AudioSource audio = gameObject.GetComponentInChildren<AudioSource>();
            print(audio);
            audio.pitch = Random.Range(0.9f, 1.1f);
            audio.PlayOneShot(audioclip);
            collision.gameObject.GetComponentInChildren<ParticleSystem>().startLifetime += boostParticle;
            collision.gameObject.GetComponent<PlayerController>()._speed += 0.4f + (collision.transform.position.y / 102);
            spawner.Spawn(booster);
            StartCoroutine(dead());
        }
    }
   private void Update()
   {
       if ((Mathf.Abs(camera.position.x - transform.position.x) > 10 || Mathf.Abs(camera.position.y - transform.position.y) > 6))
        {
            if(used == false) { 
            spawner.Spawn(booster);
            Destroy(booster);
            }
      }
        
    }
    private IEnumerator dead()
    {
        used = true;
        Destroy(gameObject.GetComponent<SpriteRenderer>());
        Destroy(gameObject.GetComponent<BoxCollider2D>());
        yield return new WaitForSeconds(1);
        Destroy(booster);
    }
}
