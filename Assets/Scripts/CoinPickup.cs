using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public int scoreGive;
    private ScoreManager sManager;


    // Use this for initialization
	void Start () {
        sManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            sManager.ScoreAdd(scoreGive);
            gameObject.SetActive(false);
        }
    }
}
