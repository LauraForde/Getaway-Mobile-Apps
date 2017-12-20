using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public string username;

	public void PlayGame()
    {
        SceneManager.LoadScene(username);
    }

}
