using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkriptaOsvjetljaj : MonoBehaviour {
    public Light lt;
    // Use this for initialization
    void Start () {
        GameObject g = GameObject.Find("/FPSController/FirstPersonCharacter");
        //GameObject g2 = GameObject.Find("/Canvas");
        // tekst = g2.GetComponent<Text>();
        lt = g.GetComponent<Light>();
        
    }
	
	// Update is called once per frame
	void Update () {
        lt.spotAngle = 100;

    }
}
