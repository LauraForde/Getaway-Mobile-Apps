using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public string menu;

	public Transform midPlatGen;
	private Vector3 midStart;
	public Transform groundPlatGen;
	private Vector3 groundStart;
	public Transform roofPlatGen;
	private Vector3 roofStart;
	public PlayerController playerRegen;
	private Vector3 playerStart;

	private Destroyer[] destroy;

	// Use this for initialization
	void Start () {
		midStart = midPlatGen.position;
		groundStart = groundPlatGen.position;
		roofStart = roofPlatGen.position;
		playerStart = playerRegen.transform.position;
	}
	
	// Update is called once per frame
	void Update (){

		if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Input.GetKeyDown(KeyCode.E)){
			SceneManager.LoadScene(menu);
		}
	}
		
	public void Restart(){
		StartCoroutine ("RestartCo");
	}
	public IEnumerator RestartCo(){

		playerRegen.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);

		destroy = FindObjectsOfType<Destroyer> ();
		for(int i = 0; i < destroy.Length; i++){
			destroy [i].gameObject.SetActive (false);
		}

		playerRegen.transform.position = playerStart;
		midPlatGen.position = midStart;
		groundPlatGen.position = groundStart;
		roofPlatGen.position = roofStart;
		playerRegen.gameObject.SetActive (true);
	}
}
