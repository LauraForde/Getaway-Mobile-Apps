using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlatformGen : MonoBehaviour {

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

	private CoinGen coinGen;
	public float randCoin;

	// Use this for initialization
	void Start () {
		//width = platform.GetComponent<BoxCollider2D> ().size.x;
		pWidth = new float[objPool.Length];

		for(int i = 0; i < objPool.Length; i++){
			pWidth [i] = objPool[i].pooledObject.GetComponent<BoxCollider2D> ().size.x;
		}

		coinGen = FindObjectOfType<CoinGen> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < genPoint.position.x) {

			distance = Random.Range (distanceMin, distanceMax);
			select = Random.Range (0, objPool.Length);
			transform.position = new Vector3 (transform.position.x + pWidth[select] + distance, transform.position.y, transform.position.z);

			//Instantiate (/*platform*/ objPool[select], transform.position, transform.rotation);
			GameObject newPlat = objPool[select].GetPooledObject();

			newPlat.transform.position = transform.position;
			newPlat.transform.rotation = transform.rotation;
			newPlat.SetActive (true);

			if (Random.Range (0f, 50f) < randCoin) {
				coinGen.CoinMaker (new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));
			}
		}
			
	}
}
