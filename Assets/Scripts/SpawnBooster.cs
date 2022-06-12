using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBooster : MonoBehaviour
{
    public float boostParticle;
    public GameObject boost;
    private GameObject spawnBoost;
    private Transform camera;
    private spawner spawner;
    private int count;
    public AudioClip audioclip;
    // Update is called once per frame
    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        spawner = GameObject.FindGameObjectWithTag("Respawn").GetComponent<spawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 7)
        {
            AudioSource audio = gameObject.GetComponentInChildren<AudioSource>();
            print(audio);
            audio.pitch = Random.Range(0.9f, 1.1f);
            audio.PlayOneShot(audioclip, 1);
            collision.gameObject.GetComponentInChildren<ParticleSystem>().startLifetime += boostParticle;
            collision.gameObject.GetComponent<PlayerController>()._speed += 0.5f + (collision.transform.position.y / 102);
            spawner.Spawn(boost);
            StartCoroutine(dead());
        }
        if (collision.gameObject.layer == 8)
        {
            spawner.Spawn(boost);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (Mathf.Abs(camera.position.x - transform.position.x) > 10 || Mathf.Abs(camera.position.y - transform.position.y) > 6)
        {
            spawner.Spawn(boost);
            Destroy(gameObject);
        }
    }
    IEnumerator dead()
    {
        Destroy(gameObject.GetComponent<SpriteRenderer>());
        Destroy(gameObject.GetComponent<BoxCollider2D>());
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
