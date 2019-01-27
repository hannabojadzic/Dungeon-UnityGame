using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ShowHighScore : MonoBehaviour {
    float f;
    Text t;
    // Use this for initialization
    void Start () {
        f = PlayerPrefs.GetFloat("highscore2");
        f = 1 / f * 10000;
        //GameObject g2 = GameObject.Find("/Canvas");
        //tekst = g2.GetComponent<Text>();

        //t = GameObject.Find("/Canvas").GetComponents<Text>()[0];
        GameObject g = GameObject.Find("/Canvas/highScoreText");
        t = g.GetComponent<Text>();
        t.text = f.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
