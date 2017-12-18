﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofPlatformGen : MonoBehaviour {

	public GameObject platform;
	public Transform genPoint;
	private float width;

	// Use this for initialization
	void Start () {
		width = platform.GetComponent<BoxCollider2D> ().size.x;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < genPoint.position.x) {
			transform.position = new Vector3 (transform.position.x + width, transform.position.y, transform.position.z);
			Instantiate (platform, transform.position, transform.rotation);

		}

	}
}
