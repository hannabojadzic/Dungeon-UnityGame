using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayProjekcija : MonoBehaviour {
    //public Text tekst;
    // Use this for initialization
    bool brojac1 = false;
    void Start() { }
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool isHit = Physics.Raycast(ray, out hit, 20f);
        //tekst.text = "";
        if (isHit)
        {
            
            Interakcija inter;
            inter = hit.transform.gameObject.GetComponent<Interakcija>();
            if (inter != null) { inter.Akcija();
                if(brojac1 == false)
                {
                    inter.Akcija2();
                }
            }
            brojac1 = true;

        }
    }

}
