using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalChange : MonoBehaviour {
    bool t = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUp()
    {
        PlayerPrefs.SetFloat("highscore1", Mathf.Round(Time.timeSinceLevelLoad));
        if (PlayerPrefs.GetFloat("highscore2") > PlayerPrefs.GetFloat("highscore1"))
        {
            PlayerPrefs.SetFloat("highscore2", PlayerPrefs.GetFloat("highscore1"));
        }
        Time.timeScale = 1;
        SceneManager.LoadScene("dscene4", LoadSceneMode.Single);
        Time.timeScale = 1;

    }
}
