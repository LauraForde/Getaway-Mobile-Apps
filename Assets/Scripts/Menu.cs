using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public string play;

	public void PlayGame()
    {
        SceneManager.LoadScene(play);
    }

}
