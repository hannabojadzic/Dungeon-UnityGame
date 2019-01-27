using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoTexScript : MonoBehaviour {
    public MovieTexture movTexture = new MovieTexture();
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        GetComponent<UnityEngine.Video.VideoPlayer>().Play();
        //GetComponent<Renderer>().material.mainTexture = movTexture;
        //movTexture.Play();

        //GameObject.Find("axeball2").GetComponent<Transform>().Rotate(-Vector3.forward, brzinaRotiranja);

        //GameObject.Find("axeball2").GetComponent<Transform>().Translate(-Vector3.up * brzinaKretanja);

        //kocka.GetComponent<Renderer>().material.color = boja1;
    }
    void OnTriggerExit(Collider col)
    {
        GetComponent<UnityEngine.Video.VideoPlayer>().Stop();
        //kocka.GetComponent<Renderer>().material.color = boja2;
    }
}
