using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 2f;
    Rigidbody enemyRb;
    GameObject player;
    public ParticleSystem deathExplosion;
    


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = ((player.transform.position - transform.position)).normalized;

        enemyRb.AddForce(lookDirection * speed * Time.deltaTime, ForceMode.VelocityChange);
        if (deathExplosion == null)
        {
            Debug.LogError("La partícula no está asignada en el Inspector.");
            return;
        }
        if (transform.position.y < -5)
        {
            Debug.Log("El enemigo ha caído, generando partícula...");
            Instantiate(deathExplosion.gameObject, transform.position, deathExplosion.transform.rotation);
            AudioManager.Instance.PlaySFX("Explosion");
            Destroy(gameObject);
        }
    }
}
