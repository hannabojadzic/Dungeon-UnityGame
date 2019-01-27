using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            /*if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }*/
            // SceneManager.LoadScene("main_menu_scene", LoadSceneMode.Single);
            Loadd();

        }
    }
    void Loadd()
    {
        //Destroy(GameObject.Find("FPSController"));
        Time.timeScale = 1;
        SceneManager.LoadScene("dscene2", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
