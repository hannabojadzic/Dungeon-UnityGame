using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickKamen : MonoBehaviour {
    bool idi = false;
    public float brzinaKretanja = 15f;
    // Use this for initialization
    void Start () {
        /*float t = 0f;
        while (t < 2f)
        {
            GameObject.Find("resetke").GetComponent<Transform>().Translate(Vector3.down * brzinaKretanja * Time.deltaTime);

            t += Time.deltaTime / 5;
        }*/

    }

    // Update is called once per frame
    void Update () {
        if (idi)
        {
            GameObject.Find("resetke").GetComponent<Transform>().Translate(-Vector3.up * brzinaKretanja );
        }
    }
    void OnMouseDown()
    {
        idi = true;
        GetComponent<Transform>().Translate(-Vector3.up * brzinaKretanja * Time.deltaTime);

        // ClickKamen2 c = new ClickKamen2();
        // c.Fun();
        // this object was clicked - do something
        Destroy(GameObject.Find("obicna_kocka"));
       
    }
}




