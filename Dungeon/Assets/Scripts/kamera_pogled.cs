using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_pogled : MonoBehaviour {

    public Transform kamera;

    


// Use this for initialization
void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K))
        {

            kamera.transform.LookAt(transform);

        }
    }
}
