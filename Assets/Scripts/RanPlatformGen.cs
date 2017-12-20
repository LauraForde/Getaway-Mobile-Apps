using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanPlatformGen : MonoBehaviour {

	public GameObject platform;
	public Transform genPoint;
	public float distance;
	private float width;
	public float distanceMin;
	public float distanceMax;
	public ObjectPooler[] objPool;
	//public GameObject[] randPlatform;
	private int select;
	private float[] pWidth;
	private float minHeight;
	public Transform max;
	private float maxHeight;
	public float heightChange;
	private float change;
	private CoinGen coinGen;
	public float randCoin;

	// Use this for initialization
	void Start () {
		//width = platform.GetComponent<BoxCollider2D> ().size.x;

		pWidth = new float[objPool.Length];

		for(int i = 0; i < objPool.Length; i++){
			pWidth [i] = objPool[i].pooledObject.GetComponent<BoxCollider2D> ().size.x;
		}

		minHeight = transform.position.y;
		maxHeight = max.position.y;

		coinGen = FindObjectOfType<CoinGen> ();
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < genPoint.position.x) {

			distance = Random.Range (distanceMin, distanceMax);
			select = Random.Range (0, objPool.Length);

			change = transform.position.y + Random.Range (heightChange, -heightChange);

			if (change > maxHeight) {
				change = maxHeight;
			} else if (change < minHeight) {
				change = minHeight;
			}
			transform.position = new Vector3 (transform.position.x + (pWidth[select] / 2) + distance, change, transform.position.z);
			//Instantiate (randPlatform[select], transform.position, transform.rotation);

			GameObject newPlat = objPool[select].GetPooledObject();

			newPlat.transform.position = transform.position;
			newPlat.transform.rotation = transform.rotation;
			newPlat.SetActive (true);

			if (Random.Range (0f, 50f) < randCoin) {
				coinGen.CoinMaker (new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));
			}

			transform.position = new Vector3 (transform.position.x + (pWidth[select] / 2), transform.position.y, transform.position.z);
		}

	}
}
