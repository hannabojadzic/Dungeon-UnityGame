using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
public class Interakcija : MonoBehaviour
{
    public float brzinaKretanja = 0.05f;
    public float brzinaRotiranja = 50f;
    public Light lt;
    public Text tekst;
    GameObject bodlje;
    void Start() { GameObject g = GameObject.Find("/FPSController/FirstPersonCharacter");
        //GameObject g2 = GameObject.Find("/Canvas");
       // tekst = g2.GetComponent<Text>();
        lt = g.GetComponent<Light>();
        bodlje = GameObject.Find("bodlje_za_krst");
    }
    void Update() { }
    public void Akcija() {
        lt.intensity = 0.3F;
       // bodlje.GetComponent<Transform>().Translate(Vector3.forward * brzinaKretanja * Time.deltaTime);

        //FPSController.GetComponent<FirstPersonController>().enabled = false;
        //GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
        // tekst.text = "ZAGONETKA";
    }
    public void Akcija2()
    {
      /*  float t = 0f;
       while (t < 2f)
        {
            t += Time.deltaTime / 5; 
             }*/
        bodlje.GetComponent<Transform>().Translate(Vector3.forward * brzinaKretanja );

        //FPSController.GetComponent<FirstPersonController>().enabled = false;
        //GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
        // tekst.text = "ZAGONETKA";
    }
}
