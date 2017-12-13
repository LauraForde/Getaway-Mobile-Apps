using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highText;

    public float scoreCount;
    public float highCount;

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
}
