using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CongratsLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUp()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GoodHighScore", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
