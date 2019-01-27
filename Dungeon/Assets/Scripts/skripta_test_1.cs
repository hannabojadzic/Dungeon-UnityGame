using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skripta_test_1 : MonoBehaviour {

    private Light svjetlo;
    // Use this for initialization
    void Start()
    {
        svjetlo = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            svjetlo.enabled = !svjetlo.enabled;
        }

    }

}
