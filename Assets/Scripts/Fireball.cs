using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    //public float speed;
    private Rigidbody2D rigid;
    public GameObject fireEffect;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
      //  rigid.velocity = new Vector2(speed, 0);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(fireEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
