using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawn : MonoBehaviour {

    public GameObject coin;
    public float delayTimer = 0.5f;
    float timer;

	// Use this for initialization
	void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D() {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Instantiate(coin, transform.position, transform.rotation);
            timer = delayTimer;
        }
	}
}
