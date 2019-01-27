using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    double speed = 5.0;
    double rotateSpeed = 2.0;
    float smooth = 2.0F;
    float tiltAngle = 30.0F;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       
            var tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
            var tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
            var target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
            // Dampen towards the target rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, target,
                                           Time.deltaTime * smooth); ;
        
    }

   
}
