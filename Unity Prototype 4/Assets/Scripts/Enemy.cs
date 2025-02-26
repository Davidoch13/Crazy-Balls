using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 1.5f;
    Rigidbody enemyRb;
    GameObject player;
    


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

        if(transform.position.y < -10)
        {
            Destroy(gameObject) ;
        }
    }
}
