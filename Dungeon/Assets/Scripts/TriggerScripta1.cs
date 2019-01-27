using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScripta1 : MonoBehaviour
{
    public Color boja1;
    public Color boja2;
    public float brzinaRotiranja = 20f;
    bool t = false;
   
    // Use this for initialization
    void Start() { }
    void Update() { if(t) GameObject.Find("axeball2").GetComponent<Transform>().Rotate(-Vector3.forward, brzinaRotiranja*Time.deltaTime);
    }
    void OnTriggerEnter(Collider col)
    {
        t = true;
        //GameObject.Find("axeball2").GetComponent<Transform>().Rotate(-Vector3.forward, brzinaRotiranja);

        //GameObject.Find("axeball2").GetComponent<Transform>().Translate(-Vector3.up * brzinaKretanja);

        //kocka.GetComponent<Renderer>().material.color = boja1;
    }
    void OnTriggerExit(Collider col)
    {
        t = false;
        //kocka.GetComponent<Renderer>().material.color = boja2;
    }
}
