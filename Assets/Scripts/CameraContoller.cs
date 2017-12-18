using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour {

	public PlayerController player;
	private Vector3 lastPosition;
	private float distanceMove;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController>();
		lastPosition = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		distanceMove = player.transform.position.x - lastPosition.x;

		transform.position = new Vector3 (transform.position.x + distanceMove, transform.position.y, transform.position.z);

		lastPosition = player.transform.position;
	}
}
