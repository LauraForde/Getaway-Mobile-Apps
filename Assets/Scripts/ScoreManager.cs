using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highText;

    public float scoreCount;
    public float highCount;
	public GameObject player;
	public int pLife;
	public GameObject[] pHearts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(scoreCount > highCount)
        {
            highCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highCount);
        }
        scoreText.text = "Score: " + scoreCount;
        highText.text = "High Score: " + highCount;
	}

    public void ScoreAdd(int score)
    {
        scoreCount += score;
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
