using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        PlayerPrefs.SetFloat("highscore2", 500000F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
