﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlatformGen : MonoBehaviour {

	public GameObject platform;
	public Transform genPoint;
	public float distance;
	private float width;
	public float distanceMin;
	public float distanceMax;
	//public ObjectPooler objPool;
	public GameObject[] randPlatform;
	private int select;

	// Use this for initialization
	void Start () {
		width = platform.GetComponent<BoxCollider2D> ().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < genPoint.position.x) {

			distance = Random.Range (distanceMin, distanceMax);
		
			transform.position = new Vector3 (transform.position.x + width + distance, transform.position.y, transform.position.z);

			select = Random.Range (0, randPlatform.Length);

			Instantiate (/*platform*/ select[, transform.position, transform.rotation);
			/*GameObject newPlat = objPool.GetPooledObject();

			newPlat.transform.position = transform.position;
			newPlat.transform.rotation = transform.rotation;
			newPlat.SetActive (true);*/
		}
			
	}
}
