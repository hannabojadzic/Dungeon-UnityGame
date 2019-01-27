using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class naScenu1 : MonoBehaviour {



    void OnMouseUp()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("dscene1", LoadSceneMode.Single);
        Time.timeScale = 1;
    }


}
