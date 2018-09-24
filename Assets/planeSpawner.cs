﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeSpawner : MonoBehaviour {

    public GameObject planes;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate ;
    float nextSpawn = 1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-6.5f, 3.0f);
            randX = Random.Range(-6.5f, 6.0f);
            //whereToSpawn = new Vector2(randX, transform.position.y);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(planes, whereToSpawn, Quaternion.identity);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(planes);
    }
}
