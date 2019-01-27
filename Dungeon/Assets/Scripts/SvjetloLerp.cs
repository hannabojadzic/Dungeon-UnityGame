using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvjetloLerp : MonoBehaviour {
    Light lt;
    Light lt2;
    float currentTime = 0f;
    float timeToMove = 60f;
    bool svjetlo = false;
    // Use this for initialization
    void Start () {
        lt = GameObject.Find("/lampa/l1").GetComponent<Light>();
        lt2 = GameObject.Find("/lampa/l2").GetComponent<Light>();
        svjetlo = false;
    }
	
	// Update is called once per frame
	void Update () {
      
        if (svjetlo)
        {
            if (currentTime <= timeToMove)
            {
                currentTime += Time.deltaTime;
                lt.intensity = Mathf.Lerp(0f, 30f, currentTime / timeToMove);
                lt2.intensity = Mathf.Lerp(0f, 30f, currentTime / timeToMove);
            }
            else
            {
                lt.intensity = 30f;
                lt2.intensity = 30f;
             currentTime = 0f;
                svjetlo = false;
            }
            //lt.intensity = Mathf.Lerp(0f, 30f, currentTime / timeToMove);
            //lt2.intensity = Mathf.Lerp(0f, 30f, currentTime / timeToMove);
        }
        


    }
    void OnMouseUp()
    {
        svjetlo = true;
       // lt.intensity = Mathf.Lerp(0f, 30f, Time.time / 50);
       // lt2.intensity = Mathf.Lerp(0f, 30f, Time.time / 50);
    }
    /*
    void OnTriggerEnter(Collider col)
    {
        svjetlo = true;
        lt.intensity = Mathf.Lerp(0f, 30f, Time.time / 50);
        lt2.intensity = Mathf.Lerp(0f, 30f, Time.time / 50);
       
    }
    */
}
