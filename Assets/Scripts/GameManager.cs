using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public int pLife;
	public GameObject[] pHearts;

	public string menu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Input.GetKeyDown(KeyCode.E)){
			SceneManager.LoadScene(menu);
		}
	}

	public void Hurt(){
		pLife -= 1;
		for(int i = 0; i < pHearts.Length; i++){
			if(pLife > i){
				pHearts[i].SetActive(true);
			}
			else{
				pHearts[i].SetActive(false);
			}
		}
	}
}
